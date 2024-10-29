using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        public string? Modelo { get; set; }
        public string? Eixo { get; set; }
        public string? Placa { get; set; }
        public float? VolumeCarreta { get; set; }

    }
}
