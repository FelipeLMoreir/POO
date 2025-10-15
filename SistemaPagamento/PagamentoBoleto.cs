using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    internal class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento()
        {
            base.ProcessarPagamento();
            Console.WriteLine("Pago com Boleto!!! ");
        }
    }
}
