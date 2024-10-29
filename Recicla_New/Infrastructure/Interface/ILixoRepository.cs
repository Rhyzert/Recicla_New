using Domain.Entities;
using System;

namespace Infrastructure.Interface
{
    public interface ILixoRepository
    {
        public Lixo GetLixo(int id);
        public List<Lixo> GetLixos();
        public void InsertLixo(Lixo lixo);
        public void UpdateLixo(Lixo lixo);
        public void DeleteLixo(Lixo lixo);
    }

}
