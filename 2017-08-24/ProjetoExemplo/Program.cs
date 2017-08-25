using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Id = 2;

            Console.WriteLine(p.Id);

           

            Carro c = new Carro();
            c.Placa = "ABC-1221";

            p.carro = c;

            Console.WriteLine(p.carro.Placa);

            Console.ReadKey();

        }
    }
}
