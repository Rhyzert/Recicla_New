namespace DomainService.Interface
{
    public interface IColetaService
    {
        Coleta GetColeta(int id);
        List<Coleta> GetColetas();
        void InsertColeta(Coleta coleta);
        void UpdateColeta(Coleta coleta);
        void DeleteColeta(int id);

    }
}
