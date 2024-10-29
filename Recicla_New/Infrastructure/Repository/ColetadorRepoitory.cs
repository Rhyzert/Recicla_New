using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using static Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class ColetadorRepository : IColetadorRepository
    {

        private readonly SqlContext _context;

        public ColetadorRepository(SqlContext context)
        {
            _context = context;
        }

        public Coletador GetColetador(int id)
        {
            try
            {
                return _context.Coletadores.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Coletador> GetColetadores()
        {
            try
            {
                return _context.Coletadores.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertColetador(Coletador coletador)
        {
            try
            {
                _context.Coletadores.Add(coletador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateColetador(Coletador coletador)
        {
            try
            {
                _context.Entry(coletador).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteColetador(Coletador coletador)
        {
            try
            {
                _context.Set<Coletador>().Remove(coletador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
