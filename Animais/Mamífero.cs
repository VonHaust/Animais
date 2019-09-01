using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Mamífero : Animal
    {
        //You and me baby ain't nothin' but mammals, so let's do it like they do on the Discovery Channel ♪
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Mamíferos, em geral, se locomovem para frente ou para trás. Com exceções de espécies que fazem mais ações.");
        }

        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("Mamíferos se comunicam emitindo sons através da boca.");
        }

        public void Amamenta()
        {
            Console.WriteLine("Mamíferos se alimentam de leite materno até terem capacidade de buscarem a própria comida.");
        }
    }
}
