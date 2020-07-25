  class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(" ");

            int L = int.Parse(input[0]);
            int x = int.Parse(input[1]);

            int notEnter = 0;
            int persons = 0;

            while (x-- > 0)
            {
                string[] activity = Console.ReadLine().Split(" ");
                int ev = plusOrMinus(activity[0], int.Parse(activity[1]));
                persons += ev;

                if(persons > L)
                {
                    notEnter++;
                    persons -= ev;
                }
            }
            
            Console.WriteLine(notEnter);
        }

        public static int plusOrMinus(string str, int nr)
        {
            if (str.ToLower().Equals("enter"))
            {
                nr = nr;
            }
            else if (str.ToLower().Equals("leave"))
            {
                nr = -Math.Abs(nr);
            }
            return nr;
        }


    }
