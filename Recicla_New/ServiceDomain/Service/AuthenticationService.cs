using Infrastructure.Authentication.Interfaces;
using Infrastructure.Interface;
using Microsoft.Identity.Client;
using ServiceDomain.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Service
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepsitory;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepsitory = userRepository;
        }
        public AuthenticationResult Register(string firstName, string lastName, string email)
        {
            if (_userRepsitory.UsuarioPorEmail(email) is not null)
            {
                throw new Exception("Atenção ! Esse Usuário ja existe.");
            }
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            var usuario = new User();

            return new AuthenticationResult(
                usuario,
                token);
        }

        public AuthenticationResult Login(string username, string password) 
        {
            if (_userRepsitory.UsuarioPorLogin(username) is not User user)
            {
                throw new Exception("Atenção ! Esse Usuário ja existe.");
            }
            if (user.Password == password)
            {
                throw new Exception("A senha esta incorreta.");
            }

            var token = _jwtTokenGenerator.GenerateToken(user.Id, user.Nome, user.Sobrenome);
            return new AuthenticationResult(user.Id,token);
            

        }
       
    }
}
