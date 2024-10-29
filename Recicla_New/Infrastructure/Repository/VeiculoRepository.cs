using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;


namespace Infrastructure.Repository
{
 
    public class VeiculoRepository : IVeiculoRepository
    {

        private readonly SqlContext _context;

        public VeiculoRepository(SqlContext context)
        {
            _context = context;
        }

        public Veiculo GetVeiculo(int id)
        {
            return _context.Veiculos.Find(id);
        }

        public List<Veiculo> GetVeiculos()
        {
            return _context.Veiculos.ToList();

        }

        public void InsertVeiculo(Veiculo veiculo)
        {
            try
            {
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateVeiculo(Veiculo veiculo)
        {
            try
            {
                _context.Entry(veiculo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteVeiculo(int veiculo)
        {
            try
            {
                var veiculoRemovido = _context.Set<Veiculo>().Find(veiculo);
                _context.Set<Veiculo>().Remove(veiculoRemovido);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
