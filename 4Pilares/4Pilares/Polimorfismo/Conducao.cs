using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Polimorfismo
{
    public class Conducao
    {
        public string Tipo { get; set; }

        public virtual void Ligando()
        {
            Console.WriteLine("virando a ignição...");
            Console.WriteLine("Motor ligado");

        }
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerar a rotacao....");
            Console.ReadLine();
        }
    }
}
