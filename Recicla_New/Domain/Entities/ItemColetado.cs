using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("ItensColetados")]
    public class ItemColetado
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Volume { get; set; }
        public string PesoAproximado { get; set; }
        public string Material { get; set; }

    }

}
