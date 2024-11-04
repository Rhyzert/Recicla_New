using ApplicationService.Interface;
using Domain.Entities;
using ServiceDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class VeiculoApplication : IVeiculoApplication
    {
        public readonly IVeiculoService _veiculoService;

        public VeiculoApplication(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public Veiculo GetVeiculo(int id)
        {
            return _veiculoService.GetVeiculo(id);
        }
        public List<Veiculo> GetVeiculos()
        {
            return _veiculoService.GetVeiculos();
        }

        public void InsertVeiculo(Veiculo veiculo)
        {
            _veiculoService.InsertVeiculo(veiculo);
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            _veiculoService.UpdateVeiculo(veiculo);
        }

        public void DeleteVeiculo(int id)
        {
            _veiculoService.DeleteVeiculo(id);
        }


    }
}
