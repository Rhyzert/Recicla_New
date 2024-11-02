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
    public class ColetadorApplication : IColetadorApplication
    {
        public readonly IColetadorService _coletadorService;

        public ColetadorApplication(IColetadorService coletadorService)
        {
            _coletadorService = coletadorService;
        }
        public List<Coletador> GetColetadores()
        {
            return _coletadorService.GetColetadores();
        }

        public Coletador GetColetador(int id)
        {
            return _coletadorService.GetColetador(id);
        }

        public void InsertColetador(Coletador coletador)
        {
            _coletadorService.InsertColetador(coletador);
        }

        public void UpdateColetador(Coletador coletador)
        {
            _coletadorService.UpdateColetador(coletador);
        }

        public void DeleteColetador(int id)
        {
            _coletadorService.DeleteColetador(id);
        }


    }
}
