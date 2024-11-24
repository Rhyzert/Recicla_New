using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Estados")]
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

    }
}
