namespace DomainService.Interface
{
    public interface IVeiculoService
    {
        Veiculo GetVeiculo(int id);
        List<Veiculo> GetVeiculos();
        void InsertVeiculo(Veiculo veiculo);
        void UpdateVeiculo(Veiculo veiculo);
        void DeleteVeiculo(int id);


    }
}
