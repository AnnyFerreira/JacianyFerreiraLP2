using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int vogal;

            Console.WriteLine("digite o texto");
            text=Console.ReadLine();
            for (int i = 0; i< text.Length ; i++)
            {
                if (text == 'a' || text == 'e' || text == 'i' || text == 'o' || text == 'u')
                {
                    i++;
                }
                else Console.WriteLine("ignore");
            }

               //exemplo do francisco
            int[] numeros = new int[n];
            int qtd = 0;
            //dsfgdfgdfg

            [ 10, 8, 7, 5, 3 , 5, 9 12 , 5]

            for (int i = 0; i < n; i++)
            {
                if(numeros[i] == 5) {
                    //qtd = qtd + 1;
                    //qtd++;
                    //qtd += 1;
                }
            }
        }


        


    }
}
