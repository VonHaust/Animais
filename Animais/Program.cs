using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Program
    {
        //Two hundred degrees
        //That's why they call me Mister Fahrenheit
        //I'm traveling at the speed of light ♪
        static void Main(string[] args)
        {
            Humano Jotaro = new Humano(17, 82, "ORAORAORAORAORAORA", 1079252850, "StarPlatinum");

           Jotaro.Cresce(4);
           Jotaro.Nasce();
           Jotaro.Reproduz();
           Jotaro.Morre();
           Jotaro.Locomove();
           Jotaro.Comunica();
           Jotaro.Amamenta();

           Pato Donald = new Pato();

           Tubarão Red = new Tubarão();

           Peixe BacalhauAlSpaghetti = new Peixe();

           Cachorro Pluto = new Cachorro();

            Console.ReadKey();
        }
    }
}
