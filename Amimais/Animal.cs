using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amimais
{
    public class Animal
    {
        public Animal animal {  get; set; }
        private string Nome { get; set; }
        private int Idade {  get; set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setIdade(int idade)
        {
            this.Idade = idade;
        }
        public int getIdade()
        {
            return this.Idade;
        }

        public virtual void EmitirSom()
        {

        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            

        }
    }
}
