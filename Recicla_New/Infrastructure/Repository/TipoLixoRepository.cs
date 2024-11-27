using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class TipoLixoRepository : ITipoLixoRepository
    {

        private readonly SqlContext _context;

        public TipoLixoRepository(SqlContext context)
        {
            _context = context;
        }


        public void InsertTipoLixo(string tiposLixo)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                // Nunca propague exceções diretamente, use throw sem ex para manter o stack trace
                throw new Exception("Erro ao inserir Tipo de Lixo", ex);
            }
        }
    }
      }



    

