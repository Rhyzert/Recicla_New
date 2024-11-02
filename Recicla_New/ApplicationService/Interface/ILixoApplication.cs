using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface ILixoApplication
    {

        Lixo GetLixo(int id);
        List<Lixo> GetLixos();
        void InsertLixo(Lixo lixo);
        void UpdateLixo(Lixo lixo);
        void DeleteLixo(int id);
    }
}
