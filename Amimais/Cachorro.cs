using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amimais
{
    public class Cachorro : Animal
    {
        public override void ExibirInfo()
        {
            base.ExibirInfo();
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}
