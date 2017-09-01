using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outro
{
    public class Disciplina
    {
        public int Id { get; set; }



        private int sigla;

        public int Teste
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public void imprimeSigla()
        {
            Console.WriteLine($"A sigla é {this.sigla}");
        }

    }
}
