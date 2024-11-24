using Domain.Entities;
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
    public class EstadoService : IEstadoService
    {
        public readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
        public Estado GetEstado(int id)
        {
            return _estadoRepository.GetEstado(id);
        }

        public List<Estado> GetEstados()
        {
            return _estadoRepository.GetEstados();
        }


        public void InsertEstado(Estado estado)
        {
            _estadoRepository.InsertEstado(estado);
        }

        public void UpdateEstado(Estado estado)
        {
            _estadoRepository.UpdateEstado(estado);
        }

        public void DeleteEstado(int id)
        {

            var estado = _estadoRepository.GetEstado(id);
            if (estado == null)
                throw new Exception("Esse estado Não Existe.");

            _estadoRepository.DeleteEstado(estado);
        }

    }
}
