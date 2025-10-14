using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Pessoa
    {
        private string Nome;
        private string Sobrenome;
        private int Idade;
        private char Sexo;
        private double Altura;
        public Endereco Endereco { get; set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.Sobrenome;
        }
        public void setIdade(int idade)
        {
            this.Idade = idade;
        }
        public int getIdade()
        {
            return this.Idade;
        }
        public void setSexo(char sexo)
        {
            this.Sexo = sexo;
        }
        public char getSexo()
        {
            return this.Sexo;
        }
        public void setAltura(double altura)
        {
            this.Altura = altura;
        }
        public double getAltura()
        {
            return this.Altura;
        }

        public void ExibirAtributos()
        {
            Console.WriteLine("Nome:" + this.Nome);
            Console.WriteLine("Sobrenome:" + this.Sobrenome);
            Console.WriteLine("Idade:" + this.Idade);
            Console.WriteLine("Sexo:" + this.Sexo);
            Console.WriteLine("Altura:" + this.Altura);
            this.Endereco.showInfo();
        }
    }
}
