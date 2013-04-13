using System;

    class IsPrime
    {
        static void Main(string[] args)
        {
            int n;
            bool flag = false;
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i < (n / 2 + 2); i++)
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
                Console.WriteLine("It's not prime");
            else
                Console.WriteLine("Prime!");
        }
    }

