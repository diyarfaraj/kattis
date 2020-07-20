using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<string> results = new List<string>();

            while(n-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');

                int r = int.Parse(input[0]);
                int e = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                if ((e - c) > r)
                    results.Add("advertise");
                else if ((e - c) < r)
                    results.Add("do not advertise");
                else
                    results.Add("does not matter");
            }

          foreach(var item in results){
            Console.WriteLine(item);
          }
          
        }
    }
