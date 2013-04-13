using System;

    class CheckBit
    {
        static void Main(string[] args)
        {
            int p,v;
            p = int.Parse(Console.ReadLine());
            v = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                v = v / 2;
            }
            bool isOne = 1 == v % 2;
            Console.WriteLine("The bit on position {0} is 1  is  ",p,isOne);
        }
    }

