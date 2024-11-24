using Domain.Entities;
using System;

namespace Infrastructure.Interface
{
    public interface IEstadoRepository
    {
        public Estado GetEstado(int id);
        public List<Estado> GetEstados();
        public void InsertEstado(Estado estado);
        public void UpdateEstado(Estado estado);
        public void DeleteEstado(Estado estado);
    }
}
