using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class ColetaRepository : IColetaRepository
    {

        private readonly SqlContext _context;

        public ColetaRepository(SqlContext context)
        {
            _context = context;
        }

        public Coleta GetColeta(int id)
        {
            try
            {
                return _context.Coletas.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Coleta> GetColetas()
        {
            try
            {
                return _context.Coletas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertColeta(Coleta coleta)
        {
            try
            {
                _context.Coletas.Add(coleta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateColeta(Coleta coleta)
        {
            try
            {
                _context.Entry(coleta).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteColeta(Coleta coleta)
        {
            try
            {
                _context.Set<Coleta>().Remove(coleta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
