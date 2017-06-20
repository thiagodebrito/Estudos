using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Encapsulamento
{
    class ObjetoExemplo : _4Pilares.Encapsulamento.IObjetoExemplo
    {
        public void Andar()
        {
            Console.WriteLine("Andando");
            Console.ReadLine();
        }
        public void Dormir()
        {
            Console.WriteLine("Dormindo");
            Console.ReadLine();
        }
        public void Comer()
        {
            Console.WriteLine("Comendo");
            Console.ReadLine();
        }
        public void Acordar()
        {
            Console.WriteLine("Acordando");
            Console.ReadLine();
        }
    }
}
