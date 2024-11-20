using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ErrorOr;
using MapsterMapper;
using MediatR;
using ApplicationService.RegisterLogin;
using Application.Common.Errors;
using ApplicationService.Common.Interfaces.Authentication;
using Domain.Common.DomainErrors;
using ApplicationService.Common.Common;
using Domain.Common.AuthDTO;
using Microsoft.EntityFrameworkCore;
using Infrastructure;
using ServiceDomain.Interface;
using ServiceDomain.Service;
using ApplicationService.Interface;
using Infrastructure.Authentication.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Infrastructure.Interface;
using Domain.Entities;



namespace Application.Controllers
{
    [Route("auth")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IJwtTokenGenerator _generateAuth;
        private readonly IUserRepository _userRepository;

        public AuthenticationController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            if (!ModelState.IsValid) {  return BadRequest(ModelState); }
            var objUser = _userRepository.UsuarioPorLogin(request.Username);
            var objEmail = _userRepository.UsuarioPorEmail(request.Email);
            if (objEmail == null && objUser == null) 
            {
                var user = new User
                {  
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
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
                return BadRequest("Usuário ja existente!."); }
                
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            var user = _userRepository.LoginUsuario(request.Username, request.Password);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt.Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Id", user.Id.ToString()),
                    new Claim("Username", user.Username.ToString()),
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
            else {return BadRequest();}


        }
    }
}
 