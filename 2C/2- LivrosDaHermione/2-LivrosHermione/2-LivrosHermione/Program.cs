using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            double pph,DD, hpd, qtdpaginas,totalT=0,totalpossivel=0;
            int n, i;
            string titulo;

           
            Console.WriteLine("Informe a quantidade de livros");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de páginas por hora");
            pph = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas diárias");
            hpd = Convert.ToDouble(Console.ReadLine());


            Livro[] livros = new Livro[n];

            for (i = 0; i < n; i++)
            {
            Livro alguem = new Livro();
            Console.WriteLine("Informe o nome do livro");
            alguem.titulo = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de paginas");
            alguem.qtdpaginas= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe quantos dias até a devolução");
            alguem.DD= Convert.ToDouble(Console.ReadLine());

            }
            totalpossivel = pph * hpd;

                if (totalpossivel/totalT =DD) 
                    Console.WriteLine("levara {0} dias para ler os livros");
                else 
                    Console.WriteLine("Os livros : {0} são impossiveis de ler");
        }
    }
}
