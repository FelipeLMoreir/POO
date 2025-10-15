using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    abstract class Pagamento
    {
        private decimal Valor {  get; set; }
        //private DateOnly DataPagamento { get; set; }
        private DateTime DataPagamento { get; set; }

        public void setValor(decimal valor)
        {
            this.Valor = valor;
        }
        //public double getValor()
        //{
        //    return this.Valor;
        //}
        public void setDataPagamento(DateTime dataPagamento)
        {
            this.DataPagamento = dataPagamento;
        }
        //public DateOnly getDataPagamento()
        //{
        //    return this.DataPagamento;
        //}
        //public virtual void ProcessarPagamento()
        //{
        //    Console.WriteLine("Digite o valor: ");
        //    this.Valor = double.Parse(Console.ReadLine()!);
        //    Console.WriteLine("Digite a data do pagamento: ");
        //    this.DataPagamento = DateOnly.Parse(Console.ReadLine()!);

        //    Console.WriteLine("Valor: " + this.Valor);
        //    Console.WriteLine("Data do Pagamento: " + this.DataPagamento);
        //}
        public abstract void ProcessarPagamento(DateTime dt, decimal valor);
    }
}
