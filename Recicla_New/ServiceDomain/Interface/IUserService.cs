using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Interface
{
    public interface IUserService
    {
        void DeleteUsuario(int id);
        User GetUsuario(int id);
        List<User> GetUsuarios();
        public User UsuarioPorEmail(string email);
        User LoginUsuario(string username, string password);
        void InsertUsuario(User usuario);
        void UpdateUsuario(User usuario);
    }
}
