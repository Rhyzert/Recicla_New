using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly SqlContext _context;

        public UserRepository(SqlContext context)
        {
            _context = context;
        }

        public User UsuarioPorEmail(string email)
        {
          var userEmail =  _context.Usuarios.FirstOrDefault(x=> x.Email == email);
          return userEmail;
        }

        public User UsuarioPorLogin(string login)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Username == login);
            return usuario;
        }

        public void DeleteUsuario(User usuario)
        {
            try
            {
                _context.Set<User>().Remove(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public User LoginUsuario(string username, string password)
        {
            try
            {
                return _context.Usuarios.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }



        public List<User> GetUsuarios()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Usuarios.ToList();

        }

        public void InsertUsuario(User usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateUsuario(User usuario)
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

        public void InsertUsuarios(User usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    }
}
