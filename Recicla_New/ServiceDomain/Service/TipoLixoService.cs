using Domain.Entities;
using ServiceDomain.Interface;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Repository;

namespace ServiceDomain.Service
{
    public class TipoLixoService : ITipoLixoService
    {
        public readonly ITipoLixoRepository _tipolixoRepository;

        public TipoLixoService(ITipoLixoRepository tipolixoRepository)
        {
            _tipolixoRepository = tipolixoRepository;
        }

        public void InsertTipoLixo(string tiposLixo)
        {
            _tipolixoRepository.InsertTipoLixo(tiposLixo);
        }

    }
}
