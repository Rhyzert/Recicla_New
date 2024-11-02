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
    public class LixoApplication : ILixoApplication
    {
        public readonly ILixoService _lixoService;

        public LixoApplication(ILixoService lixoService)
        {
            _lixoService = lixoService;
        }
        public List<Lixo> GetLixos()
        {
            return _lixoService.GetLixos();
        }

        public Lixo GetLixo(int id)
        {
            return _lixoService.GetLixo(id);
        }

        public void InsertLixo(Lixo lixo)
        {
            _lixoService.InsertLixo(lixo);
        }

        public void UpdateLixo(Lixo lixo)
        {
            _lixoService.UpdateLixo(lixo);
        }

        public void DeleteLixo(int id)
        {
            _lixoService.DeleteLixo(id);
        }


    }
}
