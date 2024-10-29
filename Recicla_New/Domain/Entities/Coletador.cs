using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Coletadores")]
    public class Coletador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string TipoCarteirao { get; set; }
    }
}
