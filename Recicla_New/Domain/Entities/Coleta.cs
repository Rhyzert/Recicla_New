using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Entities
{
    [Table("Coletas")]
    public class Coleta : ICloneable
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
        public float CapacidadeCarga { get; set; }
        public int EixoTransporte { get; set; }
        public float Latitude { get; set; } 
        public float Longitude { get; set; }

        public Coleta() { }
        public Coleta(Coleta saoPaulo)
        {
            this.Cidade = "São Paulo";
            this.CapacidadeCarga = saoPaulo.CapacidadeCarga;
            this.EixoTransporte = saoPaulo.EixoTransporte;
        }


        public object Clone()
        {
            Coleta coletaClone = (Coleta)this.MemberwiseClone();
            return coletaClone;
         }

    }


}
