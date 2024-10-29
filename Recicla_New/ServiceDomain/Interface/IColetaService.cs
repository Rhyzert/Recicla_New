using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Interface
{
    public interface IColetaService
    {
        Coleta GetColeta(int id);
        List<Coleta> GetColetas();
        void InsertColeta(Coleta coleta);
        void UpdateColeta(Coleta coleta);
        void DeleteColeta(int id);

    }
}
