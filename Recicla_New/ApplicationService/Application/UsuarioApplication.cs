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
    public class UsuarioApplication : IUsuarioApplication
    {
        public readonly IUsuarioService _usuarioService;

        public UsuarioApplication(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public List<Usuario> GetUsuario()
        {
            return _usuarioService.GetUsuarios();
        }

        public Usuario LoginUsuario(string username, string password)
        {
            return _usuarioService.LoginUsuario(username, password);
        }

        public Usuario GetUsuario(int id)
        {
            return _usuarioService.GetUsuario(id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _usuarioService.InsertUsuario(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioService.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioService.DeleteUsuario(id);
        }

    }
}
