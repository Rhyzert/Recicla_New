using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Domain.Common.AuthDTO;
using Microsoft.EntityFrameworkCore;
using Infrastructure;
using ServiceDomain.Interface;
using ServiceDomain.Service;
using ApplicationService.Interface;
using Infrastructure.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Domain.Entities;
using Domain.AuthDTO;
using System.ComponentModel.DataAnnotations;



namespace Application.Controllers
{
    [Route("auth")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuarioRepository _userRepository;
        private readonly LoginValidator _loginValidator;

        public AuthenticationController(IUsuarioRepository userRepository, IConfiguration configuration, LoginValidator loginValidator)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _loginValidator = loginValidator;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            var objUser = _userRepository.UsuarioPorUsername(request.Username);
            var objEmail = _userRepository.UsuarioPorEmail(request.Email);
            if (objEmail == null && objUser == null)
            {
                var user = new Usuario
                {
                    NomeCompleto =  request.NomeCompleto,
                    Email = request.Email,
                    Username = request.Username,
                    Password = request.Password,
                    Tipo = request.Tipo,
                    Cpf = request.Cpf,
                    Rg = request.Rg,
                    Telefone = request.Telefone,
                };
                _userRepository.InsertUsuario(user);
                return Ok("Usuário registrado com sucesso!.");


            }
            else
            {
                return BadRequest("Usuário ja existente!.");
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            var loginValidacao = _loginValidator.ValidateLogin(request);

            if (!loginValidacao.IsValid)
            {
                return BadRequest(new { errors = loginValidacao.Errors });
            }
            var user = _userRepository.LoginUsuario(request.Username, request.Password);

            var subject = _configuration["Jwt:Subject"];
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var chave = _configuration["Jwt:Key"];

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(issuer) || string.IsNullOrEmpty(audience) || string.IsNullOrEmpty(chave))
            {
                return BadRequest("Configurações do JWT estão faltando.");
            }
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Id", user.Id.ToString()),
                    new Claim("Username", user.Username.ToString() ?? string.Empty),
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn);

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user });


            }
            else { return BadRequest(); }


        }
    }
}
