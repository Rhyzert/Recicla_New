using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDomain.Notificador.Interface
{
    public interface INotificador
    {
        void EnviarMensagem(string mensagem);
    }
}
