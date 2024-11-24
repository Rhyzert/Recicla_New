using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDomain.Notificador.Interface;

namespace ServiceDomain.Notificador.Service
{
    public class NotificadorBase : INotificador
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Está faltando: {mensagem}");
        }
    }
}
