using Domain.Entities;
using ApplicationService.Interface;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class TipoReciclavelApplication : ITipoReciclavelApplication
    {
        public readonly ITipoReciclavelService _tipoReciclavelService;

        public TipoReciclavelApplication(ITipoReciclavelService tipoReciclavelService)
        {
            _tipoReciclavelService = tipoReciclavelService;
        }
        public List<TipoReciclavel> GetTiposReciclaveis()
        {
            return _tipoReciclavelService.GetTiposReciclaveis();
        }

        public TipoReciclavel GetTipoReciclavel(int id)
        {
            return _tipoReciclavelService.GetTipoReciclavel(id);
        }

        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            _tipoReciclavelService.InsertTipoReciclavel(tipoReciclavel);
        }

        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            _tipoReciclavelService.UpdateTipoReciclavel(tipoReciclavel);
        }

        public void DeleteTipoReciclavel(int id)
        {
            _tipoReciclavelService.DeleteTipoReciclavel(id);
        }


    }
}
