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
    public class LixoService : ILixoService
    {
        public readonly ILixoRepository _lixoRepository;

        public LixoService(ILixoRepository lixoRepository)
        {
            _lixoRepository = lixoRepository;
        }


        public Lixo GetLixo(int id)
        {
            return _lixoRepository.GetLixo(id);
        }

        public List<Lixo> GetLixos()
        {
            return _lixoRepository.GetLixos();
        }

        public void InsertLixo(Lixo lixo)
        {
            _lixoRepository.InsertLixo(lixo);
        }

        public void UpdateLixo(Lixo lixo)
        {
            _lixoRepository.UpdateLixo(lixo);
        }

        public void DeleteLixo(int id)
        {

            var lixo = _lixoRepository.GetLixo(id);
            if (lixo == null)
                throw new Exception("Essa detrito Não Existe.");

            _lixoRepository.DeleteLixo(lixo);
        }
    }
}
