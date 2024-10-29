using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class LixoRepository : ILixoRepository
    {

        private readonly SqlContext _context;

        public LixoRepository(SqlContext context)
        {
            _context = context;
        }

        public Lixo GetLixo(int id)
        {
            try
            {
                return _context.Lixos.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Lixo> GetLixos()
        {
            try
            {
                return _context.Lixos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertLixo(Lixo lixo)
        {
            try
            {
                _context.Lixos.Add(lixo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateLixo(Lixo lixo)
        {
            try
            {
                _context.Entry(lixo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteLixo(Lixo lixo)
        {
            try
            {
                _context.Set<Lixo>().Remove(lixo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
