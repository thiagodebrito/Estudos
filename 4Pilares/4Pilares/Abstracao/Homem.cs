using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Abstracao
{
    public class Homem : Pessoa
    {
        public Homem(int idade, string nome, string timbre) : base(idade, nome, timbre) { }
        
        public override void timbreVoz() {
            Console.WriteLine("grave");
            Console.ReadLine();
        }
        public override void andar()
        {
            Console.WriteLine("Homem andando");
            Console.ReadLine();
        }

        public override void dormir()
        {
            Console.WriteLine("Homem roncando... ZzZzZzZzZzZzZzZzZzZz");
            Console.ReadLine();
        }
    }
}
