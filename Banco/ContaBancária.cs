using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancária
    {
        private decimal Saldo {  get ; set;  }
        private string Titular { get; set; } 

        public void Depositar(decimal valor)
        {
            Console.WriteLine("Digite seu saldo: ");
            this.Saldo = decimal.Parse(Console.ReadLine()!);
            valor += Saldo;
            Console.WriteLine($"O seu saldo atual é: {valor}");
        }
        public void Sacar(decimal valor)
        {
            Console.WriteLine("Digite seu saldo: ");
            this.Saldo = decimal.Parse(Console.ReadLine()!);
            valor -= Saldo;
            Console.WriteLine($"O seu saldo atual é: {valor}");
        }
        public decimal getSaldo()
        {
            Console.WriteLine("Digite seu saldo: ");
            this.Saldo = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine($"O seu saldo atual é: {Saldo}");
            return this.Saldo;
        }
    }
}
