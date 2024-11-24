using ApplicationService.Interface;
using Domain.Entities;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class EstadoApplication : IEstadoApplication
    {
        public readonly IEstadoService _estadoService;

        public EstadoApplication(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }
        public List<Estado> GetEstados()
        {
            return _estadoService.GetEstados();
        }

        public Estado GetEstado(int id)
        {
            return _estadoService.GetEstado(id);
        }

        public void InsertEstado(Estado estado)
        {
            _estadoService.InsertEstado(estado);
        }

        public void UpdateEstado(Estado estado)
        {
            _estadoService.UpdateEstado(estado);
        }

        public void DeleteEstado(int id)
        {
            _estadoService.DeleteEstado(id);
        }


    }
}
