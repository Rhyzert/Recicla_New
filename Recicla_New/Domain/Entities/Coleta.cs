using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Coletas")]
    public class Coleta
    {
        [Key]
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string Complemento { get; set; }
        public string DataChegada { get; set; }
        public string DataSaida { get; set; }
        public float Latitude { get; set; } 
        public float Longitude { get; set; } 

    }
}
