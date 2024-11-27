using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Repository
{
    public class CaminhaoRepository : ICaminhaoRepository
    {

        private readonly SqlContext _context;

        public CaminhaoRepository(SqlContext context)
        {
            _context = context;
        }

        public Caminhao GetCaminhao(int id)
        {
            try
            {
                return _context.Caminhoes.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Caminhao> GetCaminhoes()
        {
            try
            {
                return _context.Caminhoes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertCaminhao(Caminhao coletador)
        {
            try
            {
                _context.Caminhoes.Add(coletador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateCaminhao(Caminhao coletador)
        {
            try
            {
                _context.Entry(caminhao).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertCaminhaoCloneSp(string cidade)
        {
            try
            {
                Caminhao original = new Caminhao
                {
                    Cidade = "Rio de Janeiro",
                    Modelo = "Volvo FH",
                    Placa = "ABC-1234"
                };

                Caminhao clonePrototype = (Caminhao) original.Clone();
                clonePrototype.Cidade = cidade;

            }
            catch (Exception ex) { throw ex; }
        }

        public void DeleteCaminhao(Caminhao caminhao)
        {
            try
            {
                _context.Set<Caminhao>().Remove(caminhao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
