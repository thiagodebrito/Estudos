using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _4Pilares.Abstracao;
using _4Pilares.Polimorfismo;

namespace Demonstracao4Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Heranca em Orientacao e Objetos");

            Homem pessoa = new Homem(36, "Donald", "grave");
            pessoa.andar();
            pessoa.apresentacao();
            pessoa.dormir();

            Mulher mulher = new Mulher(23, "Isabelle","suave",27);            

            mulher.andar();
            mulher.apresentacao();
            mulher.dormir();


            Onibus onibus = new Onibus();
            onibus.Acelerar();
            Console.ReadLine();
            onibus.Ligando();
            Console.ReadLine();
        }
    }
}
