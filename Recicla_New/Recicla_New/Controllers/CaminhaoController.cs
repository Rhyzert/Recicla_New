public sealed class TipoReciclavel
{
    private static TipoReciclavel _instance;
    private static readonly object _lock = new();

    // Propriedades para armazenar informações
    public int Id { get; private set; }
    public string Descricao { get; private set; }

    // Construtor privado para evitar instâncias externas
    private TipoReciclavel() { }

    // Método para obter a instância única
    public static TipoReciclavel GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new TipoReciclavel();
                }
            }
        }
        return _instance;
    }

    // Método para inicializar os campos
    public void Configurar(int id, string descricao)
    {
        if (_instance != null)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
