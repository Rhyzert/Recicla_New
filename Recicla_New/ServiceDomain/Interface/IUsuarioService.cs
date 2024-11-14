using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Interface
{
    public interface IUsuarioService
    {
        void DeleteUsuario(int id);
        User GetUsuario(int id);
        List<User> GetUsuarios();
        User LoginUsuario(string username, string password);
        void InsertUsuario(User usuario);
        void UpdateUsuario(User usuario);
    }
}
