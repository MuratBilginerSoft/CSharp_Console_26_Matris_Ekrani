using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Matris_Ekrani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
            int[,] matris = new int[10000, 10000];

            Random r = new Random();

            for (int i = 0; i < 9999; i++)
            {
                for (int j = 0; j < 9999; j++)
                {
                    int x1 = r.Next(0, 10);
                    int x2 = r.Next(0, 10);

                    matris[i, j] = x1;

                    Console.Write(matris[x1, x2] + " ");

                }
            }
        }
    }
}
