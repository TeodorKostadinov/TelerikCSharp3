using System;

    class ReplaceBitInInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position of bit to be replaced");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value");
            int v = int.Parse(Console.ReadLine());
            
            int result = 0;
            if (v == 1)
            {
                int mask = 1 << p;
                result = n | mask;
            }
            if (v == 0)
            {
                int mask = ~(1 << p); 
                result = mask & n;
            }
            Console.WriteLine("The new number is {0}",result);

        }
    }

