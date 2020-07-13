using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string cipher = Console.ReadLine().ToUpper();
            string per = "PER";

            List<string> subStrings = new List<string>();

            for (int i = 0; i < cipher.Length; i += 3)
            {
                if ((i + 3) < cipher.Length)
                    subStrings.Add(cipher.Substring(i, 3));
                else
                    subStrings.Add(cipher.Substring(i));
            }

            int days = 0;
            foreach (var item in subStrings)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if(item[i]!= per[i])
                    {
                        days++;
                    }
                }
            }

            Console.WriteLine(days);

            Console.ReadLine();
        }

    }
