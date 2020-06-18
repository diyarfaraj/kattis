using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int H = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            M -= 45;

            if(M < 0)
            {
                M += 60;
                --H;
                if (H < 0)
                {
                    H += 24;
                }
            }

            Console.WriteLine("{0} {1}",H, M);

        }

}
