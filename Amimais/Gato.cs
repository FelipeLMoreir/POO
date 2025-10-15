using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amimais
{
    public class Gato : Animal
    {
        //public override void ExibirInfo()
        //{
        //    base.ExibirInfo();
        //}
        public override string EmitirSom()
        {
            return "Miau";
        }
        public Gato(string nome, int idade) : base(nome, idade)
        {

        }
    }
}
