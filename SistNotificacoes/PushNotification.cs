using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistNotificacoes
{
    public class PushNotification : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            //Console.WriteLine($"Enviando Notificação: {mensagem}");
            base.Enviar(mensagem);  
            Console.WriteLine("Notificação enviado!");
        }
    }
}
