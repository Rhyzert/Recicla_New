using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Domain.Entities;

namespace ApplicationService.Prototype
{

    public  class ColetaPrototypeApplication
    {
        private readonly SqlContext _context;

        public ColetaPrototypeApplication(SqlContext context)
        {
            _context = context;
        }

        public  void PrototypeColeta()
        {

            var coletaOriginal = new Coleta
            {
                Cidade = "Marília",
                CEP = "17525-902",
                Endereco = "",
                Numero = 1001,
                Bairro = "Marília",
                Complemento = "",
                DataChegada = "",
                DataSaida = "",
                Latitude = 0,
                Longitude = 0
            };

            
            _context.Coletas.Add(coletaOriginal);
            _context.SaveChanges();

            // Cria uma cópia e manipula
            var coletaClone = (Coleta)coletaOriginal.Clone();
            coletaClone.Cidade = "Rio de Janeiro";
            context.Coletas.Add(coletaClone);
            context.SaveChanges();
        }
    }
}
