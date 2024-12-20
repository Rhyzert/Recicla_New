﻿using Domain.Entities;
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

        public Usuario UsuarioPorUsername(string username)
        {
            try
            {
                return _context.Usuarios.FirstOrDefault(u => u.Username == username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario UsuarioPorEmail(string email)
        {
            try
            {
                return _context.Usuarios.FirstOrDefault(u => u.Email == email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario LoginUsuario(string username, string password)
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

        public Usuario GetUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }



        public List<Usuario> GetUsuarios()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Usuarios.ToList();

        }

        public void InsertUsuario(Usuario usuario)
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

        public void InsertUsuarios(Usuario usuario)
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
