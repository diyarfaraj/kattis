using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string subString = "ss";

            if (input.ToLower().Contains(subString))
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("no hiss");
            }



            Console.ReadLine();

        }

       
    }
