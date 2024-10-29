namespace DomainService.Interface
{
    public interface ILixoService
    {
        Lixo GetLixo(int id);
        List<Lixo> GetLixos();
        void InsertLixo(Lixo lixo);
        void UpdateLixo(Lixo lixo);
        void DeleteLixo(int id);

    }
