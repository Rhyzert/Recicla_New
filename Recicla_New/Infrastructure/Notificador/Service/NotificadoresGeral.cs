using Infrastructure.Notificador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Notificador.Service
{
    //Decorator
    public class NotificadorPlaca : NotificadorDecorator
    {
        public NotificadorPlaca(INotificador notificador) : base(notificador) { }

        public override void EnviarMensagem(string mensagem)
        {
            base.EnviarMensagem($"{mensagem} - relacionado à placa");
        }
    }

    public class NotificadorModelo : NotificadorDecorator
    {
        public NotificadorModelo(INotificador notificador) : base(notificador) { }

        public override void EnviarMensagem(string mensagem)
        {
            base.EnviarMensagem($"{mensagem} - relacionado ao modelo");
        }
    }
  }
