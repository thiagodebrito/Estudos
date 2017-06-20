using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Polimorfismo
{
    public class Onibus : Conducao
    {
        public override void Acelerar()
        {
            Console.WriteLine("Onibus com motor ligado");
            Console.ReadLine();
            base.Acelerar();
        }

        public override void Ligando()
        {
            Console.WriteLine("Onibus com motor desligado");            
            base.Ligando();

        } 

    }
}
