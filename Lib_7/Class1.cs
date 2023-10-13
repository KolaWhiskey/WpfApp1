using System;

namespace Lib_7
{
    public class Class1
    {
        public static void InitMas(int Minznach, int Znach, out int[] mas)
        {
            Random rnd = new Random();
            mas = new int[Znach];
            for (int i = 0; i < Znach; i++)
            {
                mas[i] = rnd.Next(Minznach, Znach);
            }
        }
    }
    static public class Class2
    {
        public static void Raschet(int[] mas, out double[] resultat)
        {
            resultat = new double[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                double x = mas[i];
                if (x < 0)
                {
                    resultat[i] = Math.Pow(x, 2);
                }
                else
                {
                    resultat[i] = x;
                }
            }
        }


    }
}

