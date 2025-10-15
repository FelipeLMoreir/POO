using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    internal class PagamentoCartaoCredito : Pagamento
    {
        public override void ProcessarPagamento(DateTime dt, decimal valor)
        {
            //base.ProcessarPagamento();
            //Console.WriteLine("Pago com Cartão de Crédito!!! ");
            this.setValor(valor);
            this.setDataPagamento(dt);

            Console.WriteLine("Pagamento efetuado com Cartão de Crédito!\n" + valor);
        }
    }
}
