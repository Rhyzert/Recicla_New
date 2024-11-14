using Infrastructure.Interface;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;

namespace ServiceDomain.Interface
{
    public interface IAuthenticationService
    {
        public AuthenticationResult Register(string username, string password, string email);

        public AuthenticationResult Login(string username, string password);


    }

}
