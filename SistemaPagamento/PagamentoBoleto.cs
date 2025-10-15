using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    internal class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento(DateTime dt, decimal valor)
        {
            //base.ProcessarPagamento();
            //Console.WriteLine("Pago com Boleto!!! ");
            this.setValor(valor);
            this.setDataPagamento(dt);

            Console.WriteLine("Pagamento efetuado com Boleto!\nR$" + valor);
            Console.WriteLine(dt);
        }
    }
}
