using System;

namespace kattisCarrots
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');

            int num = int.Parse(nums[0]);

            for (int i = 0; i < num; i++)
            {
                Console.ReadLine();
            }

            Console.WriteLine(nums[1]);
        }

    }
}
