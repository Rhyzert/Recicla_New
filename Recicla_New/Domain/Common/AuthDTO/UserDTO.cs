using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Common.AuthDTO
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public int Tipo { get; set; }

    }}

