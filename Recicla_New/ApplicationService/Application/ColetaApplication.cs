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
    public class ColetaApplication : IColetaApplication
    {
        public readonly IColetaService _coletaService;

        public ColetaApplication(IColetaService coletaService)
        {
            _coletaService = coletaService;
        }
        public List<Coleta> GetColetas()
        {
            return _coletaService.GetColetas();
        }

        public Coleta GetColeta(int id)
        {
            return _coletaService.GetColeta(id);
        }

        public void InsertColeta(Coleta coleta)
        {
            _coletaService.InsertColeta(coleta);
        }

        public void UpdateColeta(Coleta coleta)
        {
            _coletaService.UpdateColeta(coleta);
        }

        public void DeleteColeta(int id)
        {
            _coletaService.DeleteColeta(id);
        }


    }
}
