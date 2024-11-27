using Domain.Entities;
using Infrastructure.Interface;
using Infrastructure.Notificador.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;
using Infrastructure.Notificador.Service;

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


        public void UpdateCaminhao(Caminhao caminhao)
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

        public List<string> InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "")
        {
            try
            {
                List<string> mensagens;
                INotificador notificador = new NotificadorBase();


                Caminhao original = new Caminhao
                {
                    Cidade = "Rio de Janeiro",
                    Modelo = "Volvo FH",
                    Placa = "ABC-1234"
                };
                _context.Entry(original).State = EntityState.Added;

                Caminhao clonePrototypeUm = (Caminhao)original.Clone();

                clonePrototypeUm.Placa = placaUm;
                if (modeloUm != "")
                {
                    notificador = new NotificadorModelo(notificador);
                    notificador.EnviarMensagem($"Modelo especificado: {modeloUm}");


                }

                Caminhao clonePrototypeDois = (Caminhao)original.Clone();
                clonePrototypeDois.Placa = placaDois;

                _context.Caminhoes.Add(original);
                _context.Caminhoes.Add(clonePrototypeUm);
                _context.Caminhoes.Add(clonePrototypeDois);
                _context.SaveChanges();

                mensagens = notificador.ObterMensagens();
                mensagens.Add("Caminhões clonados e inseridos com sucesso!");
                return mensagens;


            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                throw;
            }
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
