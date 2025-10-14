using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFunc
{
    public class FuncionarioCLT : Funcionario
    {
        private double Bonus;

        public void setBonus(double bonus)
        {
            this.Bonus = bonus;
        }
        public double getBonus() 
        { 
            return this.Bonus; 
        }

        public override double CalcularSalarioFinal()
        {
            return this.getSalarioBase() + this.Bonus;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Bonus: " + this.Bonus);
            Console.WriteLine("Salario Total: " + this.CalcularSalarioFinal());
        }
    }
}
