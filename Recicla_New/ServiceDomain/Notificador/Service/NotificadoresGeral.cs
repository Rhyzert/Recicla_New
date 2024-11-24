using ServiceDomain.Notificador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Notificador.Service
{
    //Decorator
    public class NotificadorComEmail : NotificadorDecorator
    {
        public NotificadorComEmail(INotificador notificador) : base(notificador) { }

        public override void EnviarMensagem(string mensagem)
        {
            base.EnviarMensagem(mensagem);
            Console.WriteLine($"Enviando mensagem também por e-mail: {mensagem}");
        }
    }

    public class NotificadorComSms : NotificadorDecorator
    {
        public NotificadorComSms(INotificador notificador) : base(notificador) { }

        public override void EnviarMensagem(string mensagem)
        {
            base.EnviarMensagem(mensagem);
            Console.WriteLine($"Enviando mensagem também por SMS: {mensagem}");
        }
    }
}
