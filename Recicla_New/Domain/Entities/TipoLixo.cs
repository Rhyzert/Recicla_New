using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("TiposLixos")]
    public class TipoLixo
    {

        private static TipoLixo _instance;


        private static readonly object _lock = new object();

        // Propriedades da entidade

        [Key]
        public int Id { get; private set; }
        public string Descricao { get; private set; }

        // Construtor privado para impedir criação de instâncias externas
        private TipoLixo()
        {
            Descricao = "Categoria genérica de lixo."; // Valor padrão
        }

        // Método estático para obter a instância única
        public static TipoLixo GetInstance()
        {
            // Garantindo que apenas uma instância seja criada
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TipoLixo();
                    }
                }
            }

            return _instance;
        }

        // Método para atualizar os valores da instância
        public void Atualizar(string descricao)
        {
            Descricao = descricao;
        }

        // Método para exibir os dados da instância
        public override string ToString()
        {
            return $"Descrição: {Descricao}";
        }
    }
}
