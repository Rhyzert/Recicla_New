namespace DomainService.Interface
{
    public interface IColetadorService
    {
        Coletador GetColetador(int id);
        List<Coletador> GetColetadores();
        void InsertColetador(Coletador coletador);
        void UpdateColetador(Coletador coletador);
        void DeleteColetador(int id);

    }
}
