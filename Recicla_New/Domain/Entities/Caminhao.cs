using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Entities
{
    [Table("Caminhao")]
    public class Caminhao : ICloneable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Modelo { get; set; }
        public string? Placa { get; set; }
        public Caminhao() { }
        public Caminhao(Caminhao caminhaClonado)
        {
            this.Cidade = "São Paulo";
            this.Modelo = caminhaClonado.Modelo;
            this.Placa = caminhaClonado.Placa;
        }


        public object Clone()
        {
            Caminhao caminhaoClone = (Caminhao)this.MemberwiseClone();
            return caminhaoClone;
        }

    }


}
