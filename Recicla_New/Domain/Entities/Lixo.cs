﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    [Table("Lixos")]
    public class Lixo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string? Cor { get; set; }
        public float? Peso { get; set; }
        public TipoReciclavel Tipo { get; set; }

    }
}
