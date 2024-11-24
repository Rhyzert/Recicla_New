using Domain.Entities;
using System;

namespace Infrastructure.Interface
{

    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();
        public Usuario GetUsuario(int id);
        public Usuario UsuarioPorUsername(string username);
        public Usuario UsuarioPorEmail(string email);
        public Usuario LoginUsuario(string username, string password);
        public void InsertUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
    }
}
