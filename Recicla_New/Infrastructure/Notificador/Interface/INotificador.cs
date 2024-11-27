using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Notificador.Interface
{
    public interface INotificador
    {
        List<string> ObterMensagens();
        void EnviarMensagem(string mensagem);
    }
}
