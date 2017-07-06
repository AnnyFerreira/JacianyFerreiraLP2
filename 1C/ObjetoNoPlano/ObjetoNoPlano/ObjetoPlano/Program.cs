using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            /* O tipo Objeto2D não existirá até que você crie uma nova 
             * classe para representá-lo em seu projeto!*/
            Objeto2D obj = new Objeto2D();
            obj.x = x;
            obj.y = y;
            /* COMPLETAR: Inicialização da posição do objeto */

            Console.Write("Digite comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                /* As proximas linhas abaixo só funcionarão corretamente caso a 
                 * classe Objeto2D tenha sido construida de forma adequada, 
                 * ou seja, que saiba realizar as tarefas de andar para a direita 
                 * e de retornar uma string exibindo suas coordenadas */

                Console.Write("Digite comando: ");
                ConsoleKey direcao = Console.ReadKey().Key;
                while (direcao != ConsoleKey.Escape)
                {
                    if (direcao == ConsoleKey.RightArrow) //RightArrow irá se mover para direita
                    {
                        obj.AndarParaDireita();
                        Console.WriteLine(obj.Coordenadas());
                    }
                    if (direcao == ConsoleKey.LeftArrow) //LeftArrow irá se mover para esquerda
                    {
                        obj.AndarParaEsquerda();
                        Console.WriteLine(obj.Coordenadas());
                    }
                    if (direcao == ConsoleKey.UpArrow) //UpArrow irá se mover para cima
                    {
                        obj.AndarParaCima();
                        Console.WriteLine(obj.Coordenadas());
                    }
                    if (direcao == ConsoleKey.DownArrow) // DownArrow vai se mover para baixo
                    {
                        obj.AndarParaBaixo();
                        Console.WriteLine(obj.Coordenadas());
                    }

                    Console.Write("Digite comando: ");
                    direcao = Console.ReadKey().Key;

                }
            }

        }
    }
}
