using Domain.Entities;
using ApplicationService.Interface;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class ItemColetadoApplication : IItemColetadoApplication
    {
        public readonly IItemColetadoService _itemColetadoService;

        public ItemColetadoApplication(IItemColetadoService itemColetadoService)
        {
            _itemColetadoService = itemColetadoService;
        }

        public ItemColetado GetItemColetado(int id)
        {
            return _itemColetadoService.GetItemColetado(id);
        }

        public List<ItemColetado> GetItensColetados()
        {
            return _itemColetadoService.GetItensColetados();
        }

        public void InsertItem(ItemColetado itemColetado)
        {
            _itemColetadoService.InsertItem(itemColetado);
        }

        public void UpdateItem(ItemColetado itemColetado)
        {
            _itemColetadoService.UpdateItem(itemColetado);
        }

        public void DeleteItem(int id)
        {
            _itemColetadoService.DeleteItem(id);
        }


    }
}
