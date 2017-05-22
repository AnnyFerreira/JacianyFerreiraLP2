using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string model;
            double km, pot;

            Console.WriteLine("Informe o modelo do carro");
            model = Console.ReadLine();
            Console.WriteLine("Informe a quilometragem do veiculo");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a potencia");
            pot = Convert.ToDouble(Console.ReadLine());

            string classifkm, classifpot;

            if (km <= 5000)
                classifkm = "novo";
            else if (km > 500)
                classifkm = "seminovo";
            else
                classifkm = "velho";

            if (pot < 120)
                classifpot = "popular";
            else if (pot == 120 && pot <= 200)
                classifpot = "forte";
            else
                classifpot = "potente";

            Console.WriteLine("{0} - {1} - {2}", model, classifkm, classifpot);
        }
    }
}
