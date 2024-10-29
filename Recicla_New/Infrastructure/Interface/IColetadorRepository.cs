using Domain.Entities;
using System;

namespace Infrastructure.Interface
{
    public interface IColetadorRepository
    {
        public List<Coletador> GetColetadores();
        public Coletador GetColetador(int id);
        public void InsertColetador(Coletador coletador);
        public void UpdateColetador(Coletador coletador);
        public void DeleteColetador(Coletador coletador);

    }
}
