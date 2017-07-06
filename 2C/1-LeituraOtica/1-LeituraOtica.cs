using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, N;
            int bemarcado = 0, ambiguo = 0;
            string resp = "*";

            Console.WriteLine("Informe o numero de questões ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de b ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de c ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de d ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de e ");
            e = int.Parse(Console.ReadLine());


            for (int i = 0; i <= N; i++)
            {
                if ('a' <= 100)
                {
                    resp = "a";
                    bemarcado++;
                }

                else if ('a' >= 101 && 'a' <= 155)
                {
                    resp = "a";
                    ambiguo++;
                }

                if ('b' <= 100)
                {
                    resp = "b";
                    bemarcado++;
                }

                else if ('b' >= 101 && 'b' <= 155)
                {
                    resp = "b";
                    ambiguo++;
                }

                if ('c' <= 100)
                {
                    resp = "c";
                    bemarcado++;
                }
                else if ('c' >= 101 && 'c' <= 155)
                {
                    resp = "c";
                    ambiguo++;
                }
                if ('d' <= 100)
                {
                    resp = "d";
                    bemarcado++;
                }
                else if ('d' >= 101 && 'd' <= 155)
                {
                    resp = "d";
                    ambiguo++;
                }
                if ('e' <= 100)
                {
                    resp = "e";
                    bemarcado++;
                }

                else if ('e' >= 101 && 'a' <= 155)
                {
                    resp = "e";
                    ambiguo++;
                }

                if (bemarcado == 0 && ambiguo == 0)
                {
                    Console.WriteLine(resp);
                }
                else
                    Console.WriteLine("*");
            }
        }
    }
}

        