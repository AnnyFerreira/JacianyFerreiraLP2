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
                    Console.WriteLine(Conversor.KgParaLb(Convert.ToDouble(Console.ReadLine())));
                }
                else if (n == 2)
                {
                    Console.WriteLine(Conversor.PolParaPes(Convert.ToDouble(Console.ReadLine())));
                }
                else if (n == 3)
                {
                    Console.WriteLine(Conversor.MParaPol(Convert.ToDouble(Console.ReadLine())));
                }
                else if (n == 4)
                {
                    Console.WriteLine(Conversor.KmParaM(Convert.ToDouble(Console.ReadLine())));
                }
                else if (n == 5)
                {
                    Console.WriteLine(Conversor.PesParaM(Convert.ToDouble(Console.ReadLine())));
                }
                else if (n == 6)
                {
                    Console.WriteLine(Conversor.GParaKG(Convert.ToDouble(Console.ReadLine())));
                }
                else
                    Console.WriteLine("Não foi possível realizar a ação");

            }

        }
    }
}
