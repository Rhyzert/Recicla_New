using Domain.Entities;
using Infrastructure.Notificador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface ICaminhaoApplication
    {

        Caminhao GetCaminhao(int id);
        List<Caminhao> GetCaminhoes();
        void InsertCaminhao(Caminhao coleta);
        List<string> InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "");
        void UpdateCaminhao(Caminhao coleta);
        void DeleteCaminhao(int id);
    }
}
