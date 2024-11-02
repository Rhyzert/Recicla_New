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
        List<Usuario> GetUsuario();
        Usuario GetUsuario(int id);
        void InsertUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
    }
}
