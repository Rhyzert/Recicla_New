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
        private readonly List<string> _mensagens; 

        public NotificadorBase()
        {
            _mensagens = new List<string>();
        }
        public void EnviarMensagem(string mensagem)
        {
            var mensagemFormatada = $"Foi modificado: {mensagem}";
            _mensagens.Add(mensagemFormatada);
        }

        public List<string> ObterMensagens()
        {
            return _mensagens; 
        }
    }
}
