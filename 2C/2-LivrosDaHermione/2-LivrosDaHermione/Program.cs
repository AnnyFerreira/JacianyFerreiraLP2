using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosDaHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            double pph, DD, hpd, qtdpaginas, totalT = 0, totalPossivel = 0;
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
                Livro livreto = new Livro();
                Console.WriteLine("Informe o nome do livro");
                livreto.titulo = Console.ReadLine();
                Console.WriteLine("Informe a quantidade de paginas");
                livreto.qtdpaginas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe quantos dias até a devolução");
                livreto.DD = Convert.ToDouble(Console.ReadLine());

            }
            
               for (i = 0; i < n; i++)
            {

                if (livros[i].DD < (livros[i].pph / hpd))
                {
                    totalT = totalT + (livros[i].pph / hpd);
                    Console.WriteLine("{0} é impossível de ser lido a tempo", livros[i].titulo);
                }
                else
                {
                    Console.WriteLine("{0} é possível de ser lido", livros[i].titulo);
                    totalPossivel = totalPossivel + (livros[i].pph / hpd);
                } 

                
            }
            Console.WriteLine("Os Livros impossíveis de serem lidos completamente até a entrega, será de: {0} dias", totalT);
            Console.WriteLine("Os livros possíveis de serem lidos completos até a entrega, será de: {0} dias", totalPossivel);
        }
    }
}

