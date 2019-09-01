using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Humano : Mamífero
    {
        //Life's a marathon and I wouldn't wanna fast-forward ♪
        public string CPF { get; protected set; }

        public void Sorri()
        {
            Console.WriteLine("O sorriso é uma expressão facial associada ao ser humano que pode significar derivados de felicidade e sadismo. Ex: (＾▽＾)");
        }

        public Humano(float age, float weight, string sound, float speed, string standName)
        {
            Idade = age;
            Peso = weight;
            Som = sound;
            Velocidade = speed;
            CPF = standName;
        }
    }
}
