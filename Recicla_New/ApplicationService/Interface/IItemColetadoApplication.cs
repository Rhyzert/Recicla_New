using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IItemColetadoApplication
    {
        ItemColetado GetItemColetado(int id);
        List<ItemColetado> GetItensColetados();
        void InsertItem(ItemColetado item);
        void UpdateItem(ItemColetado item);
        void DeleteItem(int id);
    }
}
