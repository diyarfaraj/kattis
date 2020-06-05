using System;


    class Program
    {
        static void Main(string[] args)
        {
            int totalMegbytePerMonth = int.Parse(Console.ReadLine());

            int amountMonths = int.Parse(Console.ReadLine());
            int usagePerMonth;
            
            usagePerMonth = int.Parse(Console.ReadLine());

            int firstMonthTotalMegbyte = totalMegbytePerMonth - usagePerMonth;
            firstMonthTotalMegbyte = firstMonthTotalMegbyte + totalMegbytePerMonth;
            amountMonths--;
            
            
            while (amountMonths-- > 0 && firstMonthTotalMegbyte > 0)
            {
      
                usagePerMonth = int.Parse(Console.ReadLine());
                firstMonthTotalMegbyte = (firstMonthTotalMegbyte - usagePerMonth) + totalMegbytePerMonth;
            }

            Console.WriteLine(firstMonthTotalMegbyte);
            Console.ReadLine();
        }
    
}
