using Domain.Entities;
using ServiceDomain.Interface;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Notificador.Interface;

namespace ServiceDomain.Service
{
    public class CaminhaoService : ICaminhaoService
    {
        public readonly ICaminhaoRepository _caminhaoRepository;

        public CaminhaoService(ICaminhaoRepository caminhaoRepository)
        {
            _caminhaoRepository = caminhaoRepository;
        }
        public Caminhao GetCaminhao(int id)
        {
            return _caminhaoRepository.GetCaminhao(id);
        }

        public List<Caminhao> GetCaminhoes()
        {
            return _caminhaoRepository.GetCaminhoes();
        }


        public void InsertCaminhao(Caminhao caminhao)
        {
            _caminhaoRepository.InsertCaminhao(caminhao);
        }

        public List<string> InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "")
        {
            return _caminhaoRepository.InsertCaminhaoCloneSp(placaUm, placaDois, modeloUm, modeloDois);
        }
        public void UpdateCaminhao(Caminhao caminhao)
        {
            _caminhaoRepository.UpdateCaminhao(caminhao);
        }

        public void DeleteCaminhao(int id)
        {

            var caminhao = _caminhaoRepository.GetCaminhao(id);
            if (caminhao == null)
                throw new Exception("Esse caminhão Não Existe.");

            _caminhaoRepository.DeleteCaminhao(caminhao);
        }

    }
}
