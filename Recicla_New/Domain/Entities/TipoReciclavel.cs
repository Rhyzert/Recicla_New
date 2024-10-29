using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("TipoReciclaveis")]
    public class TipoReciclavel
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Peso { get; set; }
        public string Descricao { get; set; }

    }
}
