using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int w = int.Parse(input[1]);
            int h = int.Parse(input[2]);

            double sqrt = Math.Sqrt((w * w) + (h * h));

            List<int> matchLength = new List<int>(); 
            
           while(n-- > 0)
            {
                int match = int.Parse(Console.ReadLine());
                matchLength.Add(match);
            }

           foreach(var item in matchLength)
            {
                if(item <= sqrt)
                {
                    Console.WriteLine("DA");
                } else
                {
                    Console.WriteLine("NE");
                }
            }

            Console.ReadLine();
        }
    
}
