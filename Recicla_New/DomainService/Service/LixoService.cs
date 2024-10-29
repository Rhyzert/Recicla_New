using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class ItemColetadoService : IItemColetadoService
    {
        public readonly IItemColetadoRepository _itemColetadoRepository;

        public ItemColetadoService(IItemColetadoRepository itemColetadoRepository)
        {
            _itemColetadoRepository = itemColetadoRepository;
        }


        public ItemColetado GetItemColetado(int id)
        {
            return _itemColetadoRepository.GetItemColetado(id);
        }

        public List<ItemColetado> GetItensColetados()
        {
            return _itemColetadoRepository.GetItensColetados();
        }

        public void InsertItem(ItemColetado item)
        {
            _itemColetadoRepository.InsertItem(item);
        }

        public void UpdateItem(ItemColetado item)
        {
            _itemColetadoRepository.UpdateItem(item);
        }

        public void DeleteItem(int id)
        {

            var itemColetado = _itemColetadoRepository.GetItemColetado(id);
            if (itemColetado == null)
                throw new Exception("Essa denuncia Não Existe.");

            _itemColetadoRepository.DeleteItem(itemColetado);
        }
    }
}
