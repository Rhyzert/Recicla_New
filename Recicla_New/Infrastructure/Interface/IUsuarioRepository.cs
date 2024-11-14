using Domain.Entities;
using System;

namespace Infrastructure.Interface
{

    public interface IUsuarioRepository
    {
        public List<User> GetUsuarios();
        public User GetUsuario(int id);
        public User LoginUsuario(string username, string password);
        public void InsertUsuario(User usuario);
        public void UpdateUsuario(User usuario);
        public void DeleteUsuario(User usuario);
    }
}
