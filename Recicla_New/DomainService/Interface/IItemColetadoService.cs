namespace DomainService.Interface
{
    public interface IItemColetadoService
    {
        ItemColetado GetItemColetado(int id);
        List<ItemColetado> GetItensColetados();
        void InsertItem(ItemColetado itemColetado);
        void UpdateItem(ItemColetado itemColetado);
        void DeleteItem(int id);

    }
}
