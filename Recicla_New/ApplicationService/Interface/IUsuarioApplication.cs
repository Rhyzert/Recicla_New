using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IUsuarioApplication
    {
        void DeleteUsuario(int id);
        List<User> GetUsuario();
        User GetUsuario(int id);
        User LoginUsuario(string username, string password);
        void InsertUsuario(User usuario);
        void UpdateUsuario(User usuario);
    }
}
