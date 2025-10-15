using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    abstract class Pagamento
    {
        private double Valor {  get; set; }
        private DateOnly DataPagamento { get; set; }

        public void setValor(double valor)
        {
            this.Valor = valor;
        }
        public double getValor()
        {
            return this.Valor;
        }
        public void setDataPagamento(DateOnly dataPagamento)
        {
            this.DataPagamento = dataPagamento;
        }
        public DateOnly getDataPagamento()
        {
            return this.DataPagamento;
        }
        public virtual void ProcessarPagamento()
        {
            Console.WriteLine("Valor: " + this.Valor);
            Console.WriteLine("Data do pagamento: " + this.DataPagamento);
        }
    }
}
