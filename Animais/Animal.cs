using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    //Yeah you can start over you can run free
    //You can find other fish in the sea ♪
    class Animal
    {
        public bool Vivo { get; protected set; }
        public float Idade { get; protected set; }
        public float Peso { get; protected set; }
        public string Som { get; protected set; }
        public float Velocidade { get; protected set; }

        public void Nasce()
        {
            Vivo = true;
            Idade = 0;
        }

        public void Cresce(float tempoDeVida)
        {
            Idade += tempoDeVida;
        }

        public Animal Reproduz()
        {
            Animal filho = new Animal();
            filho.Nasce();
            return filho;
        }

        public void Morre()
        {
            Vivo = false;
        }

        public virtual void Locomove()
        {
            Console.WriteLine("Moveu-se a uma velocidade de " + Velocidade + "KM/h");
        }

        public virtual void Comunica()
        {
            Console.WriteLine(Som);
        }
    }
}
