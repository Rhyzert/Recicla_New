using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class VeiculoService : IVeiculoService
    {
        public readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }


        public Veiculo GetVeiculo(int id)
        {
            return _veiculoRepository.GetVeiculo(id);
        }

        public List<Veiculo> GetVeiculos()
        {
            return _veiculoRepository.GetVeiculos();
        }


        public void InsertVeiculo(Veiculo veiculo)
        {
            _veiculoRepository.InsertVeiculo(veiculo);
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            _veiculoRepository.UpdateVeiculo(veiculo);
        }

        public void DeleteVeiculo(int id)
        {

            var veiculo = _veiculoRepository.GetVeiculo(id);
            if (veiculo == null)
                throw new Exception("Essa denuncia Não Existe.");

            _veiculoRepository.DeleteVeiculo(id);
        }

    }
}
