using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
{
    public class ColetaService : IColetaService
    {
        public readonly IColetaRepository _coletaRepository;

        public ColetaService(IColetaRepository coletaRepository)
        {
            _coletaRepository = coletaRepository;
        }
        public Coleta GetColeta(int id)
        {
            return _coletaRepository.GetColeta(id);
        }

        public List<Coleta> GetColetas()
        {
            return _coletaRepository.GetColetas();
        }


        public void InsertColeta(Coleta coleta)
        {
            _coletaRepository.InsertColeta(coleta);
        }

        public void UpdateColeta(Coleta coleta)
        {
            _coletaRepository.UpdateColeta(coleta);
        }

        public void DeleteColeta(int id)
        {

            var coleta = _coletaRepository.GetColeta(id);
            if (coleta == null)
                throw new Exception("Essa denuncia Não Existe.");

            _coletaRepository.DeleteColeta(coleta);
        }

    }
}
