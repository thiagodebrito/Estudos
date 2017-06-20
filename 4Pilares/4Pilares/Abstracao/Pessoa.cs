using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Pilares.Abstracao
{
    public abstract class Pessoa 
    {
        public int Idade{get;set;}
        public string Nome { get; set; }
        public string Timbre { get; set; }
        

        public Pessoa(int idade, string nome, string timbre)
        {
            this.Idade = idade;
            this.Nome = nome;
            this.Timbre = timbre;
        }

        
        public abstract void timbreVoz();

        public abstract void andar();

        public abstract void dormir();        

        public void apresentacao()
        {
            Console.WriteLine("Oi, eu me chamo "  + this.Nome);
            Console.ReadLine();
        }
    }
}
