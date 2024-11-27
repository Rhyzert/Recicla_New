using Domain.Entities;
using ApplicationService.Interface;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDomain.Service;

namespace ApplicationService.Application
{
    public class TipoLixoApplication : ITipoLixoApplication
    {
        public readonly ITipoLixoService _tipoLixoService;

        public TipoLixoApplication(ITipoLixoService tipoLixoService)
        {
            _tipoLixoService = tipoLixoService;
        }
        public void InsertTipoLixo(string tiposLixo)
        {
            _tipoLixoService.InsertTipoLixo(tiposLixo);
        }


    }
}
