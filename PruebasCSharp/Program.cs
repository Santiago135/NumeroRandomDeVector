using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSantigo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numerosRifa = new int[7, 10]
            {
                {30, 0, 0, 0, 34, 0, 36, 37, 38, 39},
                {0, 0, 42, 0, 44, 0, 46, 0, 0, 0 },
                {0, 51, 0, 53, 54, 55, 0, 0, 58, 59 },
                {0, 61, 62, 0, 64, 0, 66, 67, 68, 0 },
                {70, 0, 0, 73, 0, 75, 0, 77, 78, 0 },
                {0, 81, 0, 83, 84, 85, 0, 0, 0, 0 },
                {0, 91, 92, 93, 0, 0, 96, 97, 0, 0 },
            };

            Random randomN = new Random();
            int num, i, j = 0, contador = 0, contador2 = 0;

            while (contador < 7)
            {
                num = randomN.Next(29, 98);
                i = 0;
                while(num != numerosRifa[i, j])
                {
                    j++;
                    if(j > 9 && i < 6)
                    {
                        j = 0;
                        i++;
                    }
                    if(i == 6 && j > 9)
                    {
                        num = randomN.Next(29, 98);
                        i = 0;
                        j = 0;
                    }
                }
                Console.WriteLine("{0}\n", num);
                numerosRifa[i, j] = 0;
                
                while(contador2 < 10)
                {
                    numerosRifa[i, contador2] = 0;
                    contador2++;
                }

                contador2 = 0;
                contador++;
                j = 0;
            }
            Console.ReadKey();
        }
    }
}