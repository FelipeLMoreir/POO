using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    internal class Pessoa
    {
        //private int id;
        //private string nome;
        public int Id { get; private set; }
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        public string Nome 
        { 
            get; private set;
            //{
            //      if (value.Length < 3)
            //          Console.WriteLine("Nome muito curto");
            //      else
            //          this.Nome = value;
            //} 
        }

        public Pessoa(string nome)
        {
            Id = Random.Shared.Next(1, 100);
            Nome = nome;

            //if (nome.Length < 3)
            //{
            //    throw new ArgumentException("O nome deve ter no mínimo 3 letras");
            //}
        }
        //{
        //    get { return nome; }
        //    set { nome = value; }
        //}
    }
}
