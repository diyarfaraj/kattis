using System;
using System.Collections.Generic;
using System.Linq;

namespace PieaceOFCake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');

            int sideLength = int.Parse(dimensions[0]);
            int horizontalCut = int.Parse(dimensions[1]);
            int verticalCut = int.Parse(dimensions[2]);
            int thickness = 4;

            int cut1 = (horizontalCut * verticalCut)*thickness;
            int cut2 = ((sideLength - horizontalCut) * (sideLength - verticalCut)) * thickness;
            int cut3 = ((sideLength - horizontalCut) * verticalCut) * thickness;
            int cut4 = (horizontalCut * (sideLength - verticalCut)) * thickness;

            var allCuts = new List<int>() { cut1, cut2, cut3, cut4 };

            Console.WriteLine(allCuts.Max());
            Console.ReadLine();
        }
    }
}
