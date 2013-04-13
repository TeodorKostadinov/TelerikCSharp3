using System;

    class FindBit
    {
        static void Main(string[] args)
        {
            int i, b;
            i = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int k = 0; k < b; k++)
            {
                i = i / 2;
            }
            
            Console.WriteLine("The bit on position {0} is {1}", b, i % 2);
        } 
    }

