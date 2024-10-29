using Domain.Entities;
using System;

namespace Infrastructure.Interface
{
    public interface IColetaRepository
    {
        public Coleta GetColeta(int id);
        public List<Coleta> GetColetas();
        public void InsertColeta(Coleta coleta);
        public void UpdateColeta(Coleta coleta);
        public void DeleteColeta(Coleta coleta);
    }
}
