using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Notificador.Interface;

namespace Infrastructure.Notificador.Service
{
    public class NotificadorBase : INotificador
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Está faltando: {mensagem}");
        }
    }
}
