using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFunc 
{
    public class FuncionarioPJ : Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;

        public void setHorasTrabalhadas(int horasTrabalhadas)
        {
            this.HorasTrabalhadas = horasTrabalhadas;
        }
        public int getHorasTrabalhadas()
        {
            return this.HorasTrabalhadas;
        }

        public void setValorHora(double valorHora)
        {
            this.ValorHora = valorHora;
        }
        public double getValorHora()
        {
            return this.ValorHora;
        }

        public override double CalcularSalarioFinal()
        {
            return this.HorasTrabalhadas * this.ValorHora;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Horas Trabalhadas: " + this.HorasTrabalhadas);
            Console.WriteLine("Valor Hora: " + this.ValorHora);
            Console.WriteLine("Salario Total: " + this.CalcularSalarioFinal());
        }
    }
}
