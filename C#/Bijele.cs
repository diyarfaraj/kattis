using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            
            String[] input = Console.ReadLine().Split(" ");

            List<int> sets = new List<int>() { 1, 1, 2, 2, 2, 8 };
            

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0} ", sets[i]-int.Parse(input[i]));
            }

            Console.ReadLine();

        }

    }
    
