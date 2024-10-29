using Domain.Entities;
using System;

namespace Infrastructure.Interface
{

    public interface IItemColetadoRepository
    {
        public List<ItemColetado> GetItensColetados();
        public ItemColetado GetItemColetado(int id);
        public void InsertItem(ItemColetado coleta);
        public void UpdateItem(ItemColetado coleta);
        public void DeleteItem(ItemColetado coleta);
    }
}
