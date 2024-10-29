using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class TipoReciclavelService : ITipoReciclavelService
    {
        public readonly ITipoReciclavelRepository _tipoReciclavelRepository;

        public TipoReciclavelService(ITipoReciclavelRepository tipoReciclavelRepository)
        {
            _tipoReciclavelRepository = tipoReciclavelRepository;
        }
        public TipoReciclavel GetTipoReciclavel(int id)
        {
            return _tipoReciclavelRepository.GetTipoReciclavel(id);
        }

        public List<TipoReciclavel> GetTiposReciclaveis()
        {
            return _tipoReciclavelRepository.GetTiposReciclaveis();
        }


        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            _tipoReciclavelRepository.InsertTipoReciclavel(tipoReciclavel);
        }

        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            _tipoReciclavelRepository.UpdateTipoReciclavel(tipoReciclavel);
        }

        public void DeleteTipoReciclavel(int id)
        {

            var tipoReciclavel = _tipoReciclavelRepository.GetTipoReciclavel(id);
            if (tipoReciclavel == null)
                throw new Exception("Essa denuncia Não Existe.");

            _tipoReciclavelRepository.DeleteTipoReciclavel(tipoReciclavel);
        }

    }
}
