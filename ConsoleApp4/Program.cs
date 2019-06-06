using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int height = 10, 
           width = 10;

        static async Task Main(string[] args)
        {
            string[,] arr = new string[width, height];
            for (int i = 0; i <= width-1; i++)
            {
                for (int j = 0; j <= height-1; j++)
                {
                    if (i == j && i%2 == 0)
                    {
                        FillTheArray(i, width - j-1, j, height - i-1, ref arr);
                    }
                }
            }

            for (int i = 0; i <= width - 1; i++)
            {
                for (int j = 0; j <= height - 1; j++)
                {
                    if (arr[i, j] == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write($"A({i},{j}) ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Read();
        }

        public static void FillTheArray(int iStart, int iEnd, int jStart, int jEnd, ref string[,] arr)
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                for (int j = jStart; j <= jEnd; j++)
                {
                    if (i == iStart || i == iEnd || j == jStart || j == jEnd)
                    {
                        arr[i,j] = "1";
                    }
                    else
                    {
                        arr[i, j] = "0";
                    }
                }
            }
        }
    }
}
