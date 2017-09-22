using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conver = new Conversor();

            Console.WriteLine("1- Kg para Libra");
            Console.WriteLine("2- Polega Para Pes");
            Console.WriteLine("3- Metro Para Polega");
            Console.WriteLine("4- Km Para Metro");
            Console.WriteLine("5- Pes Para Metro");
            Console.WriteLine("6- Grama Para KG");
            Console.WriteLine("0- Sair");

           int n = int.Parse(Console.ReadLine());

            while (n !=0)
            {
                if (n == 1)
                {
                    Conversor.KgParaLb(n);
                }
                else if (n == 2)
                {
                    Conversor.PolParaPes(n);
                }
                else if (n == 3)
                {
                    Conversor.MParaPol(n);
                }
                else if (n == 4)
                {
                    Conversor.KmParaM(n);
                }
                else if ( n == 5)
                {
                    Conversor.PesParaM(n);
                }
                else if (n == 6)
                {
                    Conversor.GParaKG(n);
                }

            }

        }
    }
}
