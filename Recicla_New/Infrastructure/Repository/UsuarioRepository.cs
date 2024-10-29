using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly SqlContext _context;

        public UsuarioRepository(SqlContext context)
        {
            _context = context;
        }

        public void DeleteUsuario(Usuario usuario)
        {
            try
            {
                _context.Set<Usuario>().Remove(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuario.Find(id);
        }

        public List<Usuario> GetUsuario()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Usuario.ToList();

        }

        public void InsertFuncionario(Usuario usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public Usuario? GetUsuarioByEmail(string email)
        {
            return _context.Usuario.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}
