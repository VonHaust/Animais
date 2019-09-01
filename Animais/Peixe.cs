using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Peixe : Animal
    {
        //A fish in the airbags
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Peixes se locomovem com o movimento das nadadeiras e a corrente das águas.");
        }

        public int Barbatanas { get; protected set; }
    }
}
