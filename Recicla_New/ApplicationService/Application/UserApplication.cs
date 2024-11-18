using ApplicationService.Interface;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace ApplicationService.Application
{
    public class UserApplication : IUserApplication
    {
        public readonly IUserService _usuarioService;

        public UserApplication(IUserService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public List<User> GetUsuario()
        {
            return _usuarioService.GetUsuarios();
        }

        public User LoginUsuario(string username, string password)
        {
            return _usuarioService.LoginUsuario(username, password);
        }

        public User GetUsuario(int id)
        {
            return _usuarioService.GetUsuario(id);
        }

        public void InsertUsuario(User usuario)
        {
            _usuarioService.InsertUsuario(usuario);
        }

        public void UpdateUsuario(User usuario)
        {
            _usuarioService.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioService.DeleteUsuario(id);
        }

    }
}
