using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var subString = input.Split(' ').Distinct();

            if (input.Split(' ').Count() == subString.Count())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            Console.ReadLine();
        }

       
    }
