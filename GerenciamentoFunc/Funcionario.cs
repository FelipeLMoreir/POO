using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFunc
{
    public abstract class Funcionario
    {
        private string Nome;
        private double SalarioBase;

        public abstract double CalcularSalarioFinal();

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salario Base: " + this.SalarioBase);

        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setSalarioBase(double salarioBase)
        {
            this.SalarioBase = salarioBase;           
        }
        public double getSalarioBase()
        {
            return this.SalarioBase;
        }
    }
}
