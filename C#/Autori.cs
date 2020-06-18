using System;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string capLetters = string.Concat(name.Where(c => c >= 'A' && c <= 'Z'));

            Console.WriteLine(capLetters);
            Console.ReadLine();
        }
    }
