using Infrastructure.Notificador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Notificador.Service
{
    public abstract class NotificadorDecorator : INotificador
    {
        protected INotificador _notificador;

        public NotificadorDecorator(INotificador notificador)
        {
            _notificador = notificador;
        }

        public virtual void EnviarMensagem(string mensagem)
        {
            _notificador.EnviarMensagem(mensagem);
        }
    }
}
