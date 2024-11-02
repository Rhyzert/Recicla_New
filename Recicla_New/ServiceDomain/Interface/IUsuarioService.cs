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
        Usuario GetUsuario(int id);
        List<Usuario> GetUsuarios();
        void InsertUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
    }
}
