using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using static Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class TipoReciclavelRepository : ITipoReciclavelRepository
    {

        private readonly SqlContext _context;

        public TipoReciclavelRepository(SqlContext context)
        {
            _context = context;
        }

        public TipoReciclavel GetTipoReciclavel(int id)
        {
            try
            {
                return _context.TipoReciclaveis.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<TipoReciclavel> GetTiposReciclaveis()
        {
            try
            {
                return _context.TipoReciclaveis.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.TipoReciclaveis.Add(tipoReciclavel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.Entry(tipoReciclavel).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.Set<TipoReciclavel>().Remove(tipoReciclavel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
