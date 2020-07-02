using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            double X = double.Parse(input[0]);
            double Y = double.Parse(input[1]);
            double N = double.Parse(input[2]);

            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%X == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%Y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }


            Console.ReadLine();

        }

    }
