using Domain.Entities;
using Infrastructure.Notificador.Interface;
using System;

namespace Infrastructure.Interface
{
    public interface ICaminhaoRepository
    {
        public Caminhao GetCaminhao(int id);
        public List<Caminhao> GetCaminhoes();
        public void InsertCaminhao(Caminhao caminhao);
        public void UpdateCaminhao(Caminhao caminhao);
        public void DeleteCaminhao(Caminhao caminhao);
        public List<string> InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "");
    }
}
