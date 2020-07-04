using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] points = new int[5, 4];

                for (int i = 0; i < 5; i++)
                {
                    string[] inputNrs = Console.ReadLine().Split(' ');

                    for (int k = 0; k < 4; k++)
                    {
                        points[i, k] = int.Parse(inputNrs[k]);
                    }
                }

            int[] total = new int [5];
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                total[i] += points[i, k];
                }
            }

            int max = total.Max();
            int index = total.ToList().IndexOf(max);
            Console.WriteLine("{0} {1}", index + 1, max);
            Console.ReadLine();

        }

    }

