using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Ave : Animal
    {
        //Oh Raven won't you sing me a happy song ♪
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Aves se locomovem com o bater das asas para ganhar impulso e com as correntes do vento.");
        }

        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("Aves se comunicam com sons emitidos através do bico.");
        }

        public void Migra()
        {
            Console.WriteLine("As aves migram para buscar alimento e para regiões quentes em épocas frias.");
        }
    }
}
