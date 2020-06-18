using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int R1 = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int R2 = (S * 2) - R1;

            Console.WriteLine(R2);
        }

}
