using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz
{
    class Program
    {

        double N = 0.1;
        static double[,] massiv = { {0.25, 0.36, 0.4}, {0.75, 0.2, 0.3}, {0.35, 0.82, 0.1}, {0.8, 0.2, 0.35} };

        static int rows = massiv.GetUpperBound(0) + 1;
        static int columns = 3 ;

        static double[] Hdi = { 0 };
        double[] D_massiv;

        static double[] temp = {0, 0};
        double temp2 = 0;

        static int n;
        static double sum = 0;

        static double max;
        static double pos = 0;
        static double ids;
        static void Main(string[] args)
        {
            for (int i = 3; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                        temp[0] = temp[0] + massiv[i, j] / 3;
                 
                }
                
            }
            Console.WriteLine(temp[0]);
            for (int id = 3; id < rows; id++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    double ids = Convert.ToDouble(Math.Pow(massiv[id, j]-temp[0], 2)) / 3;
                    temp[1] = temp[1] + ids;

                    Console.WriteLine(ids);
                }

            }
            Console.WriteLine(ids);

            Console.ReadLine();
        }
    }
}


