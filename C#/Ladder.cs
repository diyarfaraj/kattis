using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int h = int.Parse(input[0]);
            int v = int.Parse(input[1]);
            
            Console.WriteLine(Math.Ceiling(h/(Math.Sin((v*Math.PI)/180))));
            Console.ReadLine();
        }

    }
