﻿using Domain.Entities;
using ServiceDomain.Interface;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Service
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<User> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }
        
        public User LoginUsuario(string username, string password)
        {
            return _usuarioRepository.LoginUsuario(username, password);
        }
        public User GetUsuario(int id)
        {
            return _usuarioRepository.GetUsuario(id);
        }

        public void InsertUsuario(User usuario)
        {
            _usuarioRepository.InsertUsuario(usuario);
        }

        public void UpdateUsuario(User usuario)
        {
            _usuarioRepository.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id)
        {
             var usuario = _usuarioRepository.GetUsuario(id);
             if (usuario == null)
             throw new Exception("Esse Usuario Não Existe.");

                _usuarioRepository.DeleteUsuario(usuario);
        }

    }
}
