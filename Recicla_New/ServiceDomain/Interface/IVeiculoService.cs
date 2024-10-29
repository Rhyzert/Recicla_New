using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Interface
{
    public interface IVeiculoService
    {
        Veiculo GetVeiculo(int id);
        List<Veiculo> GetVeiculos();      
        void InsertVeiculo(Veiculo veiculo);
        void UpdateVeiculo(Veiculo veiculo);
        void DeleteVeiculo(int id);


    }
}
