﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistNotificacoes
{
    public class SMS : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            //Console.WriteLine($"Enviando SMS: {mensagem}");
            base.Enviar(mensagem);
            Console.WriteLine("SMS enviado!");
        }
    }
}
