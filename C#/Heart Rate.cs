using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            List<double> bList = new List<double>();
            List<double> pList = new List<double>();

            while (cases-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');

                double b = double.Parse(input[0]);
                double p = double.Parse(input[1]);

                bList.Add(b);
                pList.Add(p);

            }

            for (int i = 0; i < pList.Count(); i++)
            {
                Console.WriteLine("{0} {1} {2}", string.Format("{0:f4}", (60 / pList[i]) * (bList[i] - 1)),
                                                string.Format("{0:f4}", (60 / pList[i]) * bList[i]), 
                                                string.Format("{0:f4}", (60 / pList[i]) * (bList[i] + 1)));
            }

        }
    }
