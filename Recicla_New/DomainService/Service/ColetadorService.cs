using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class ColetadorService : IColetadorService
    {
        public readonly IColetadorRepository _coletadorRepository;

        public ColetadorService(IColetadorRepository coletadorRepository)
        {
            _coletadorRepository = coletadorRepository;
        }
        public Coletador GetColetador(int id)
        {
            return _coletadorRepository.GetColetador(id);
        }

        public List<Coletador> GetColetadores()
        {
            return _coletadorRepository.GetColetadores();
        }


        public void InsertColetador(Coletador coletador)
        {
            _coletadorRepository.InsertColetador(coletador);
        }

        public void UpdateColetador(Coletador coletador)
        {
            _coletadorRepository.UpdateColetador(coletador);
        }

        public void DeleteColetador(int id)
        {

            var coletador = _coletadorRepository.GetColetador(id);
            if (coletador == null)
                throw new Exception("Essa denuncia Não Existe.");

            _coletadorRepository.DeleteColetador(coletador);
        }

    }
}
