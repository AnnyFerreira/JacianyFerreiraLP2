using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorMedidas
{
    class Conversor
    {

    public static double LbParaKg( double Lb)
    {
        return Lb/2.2;
    }
    public static double kgParaLb(double kg )
    {
            return kg*2.2;
    }
    public static double KgParag( double Kg)
    {
            return Kg/100;
    }
    public static double GParaKg(double G )
    {
            return G*100;
    }
    public static double TParaKg(double T)
    {
            return T/1000;
    }
    public static double KgParaT(double Kg)
    {
            return Kg*1000;
    }
        public static double CparaF(double C)
    {
            return (C * 0.555) + 32;
    }
        public static double FparaC(double F)
    {
            return (F-32) * 0.555;
    }
          public static double CparaK(double C)
    {
            return C+273;
    }
           public static double KparaC(double K)
    {
            return K-273;
    }
           public static double KmparaM (double Km)
    {
            return Km/1000;
    }
           public static double MparaKm(double M )
    {
            return M * 1000;
    }
           public static double KmparaMilha(double Km)
    {
            return 
    }
             public static double MilhaparaKm (double Milha)
    {
            return 
    }
             public static double PdparaM (double Pd )
    {
            return 
        }
    }
             public static double MparaPd (double M )
    {
            return 
    }
             public static double MparaPes (double M)
    {
            return M* 3.2808;
    }
             public static double PesparaM(double Pes)
    {
            return 
    }
             public static double PesparaPd (double Pes )
    {
            return 
    }
             public static double PdparaPes(double Pd )
    {
            return 
    }
         
}
