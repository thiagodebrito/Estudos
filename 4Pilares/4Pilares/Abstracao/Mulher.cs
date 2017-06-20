using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Abstracao
{
    public class Mulher :Pessoa
    {
        public Mulher(int idade, string nome, string timbre, int numSutia) : base(idade, nome, timbre) { }
        
        public int numSutia { get; set; }

        public override void timbreVoz()
        {
            Console.WriteLine("médio");
            Console.ReadLine();
        }
        public override void andar()
        {
            Console.WriteLine("Mulher andando");
            Console.ReadLine();
        }

        public override void dormir()
        {
            Console.WriteLine("Mulher dormindo... ZzZzZzZzZzZzZzZzZzZz");
            Console.ReadLine();
        }
    }
}
