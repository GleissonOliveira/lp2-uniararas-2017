using Outro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Disciplina d = new Disciplina();
            d.Teste = 4;

            d.imprimeSigla();
          
            Console.ReadKey();
        }
    }
}
