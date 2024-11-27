using ApplicationService.Interface;
using Domain.Entities;
using Infrastructure.Notificador.Interface;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class CaminhaoApplication : ICaminhaoApplication
    {
        public readonly ICaminhaoService _caminhaoService;

        public CaminhaoApplication(ICaminhaoService caminhaoService)
        {
            _caminhaoService = caminhaoService;
        }
        public List<Caminhao> GetCaminhoes()
        {
            return _caminhaoService.GetCaminhoes();
        }

        public Caminhao GetCaminhao(int id)
        {
            return _caminhaoService.GetCaminhao(id);
        }

        public void InsertCaminhao(Caminhao caminhao)
        {
            _caminhaoService.InsertCaminhao(caminhao);
        }
        public List<string> InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "")
        {
           return _caminhaoService.InsertCaminhaoCloneSp(placaUm, placaDois, modeloUm, modeloDois);
        }

        public void UpdateCaminhao(Caminhao caminhao)
        {
            _caminhaoService.UpdateCaminhao(caminhao);
        }

        public void DeleteCaminhao(int id)
        {
            _caminhaoService.DeleteCaminhao(id);
        }


    }
}
