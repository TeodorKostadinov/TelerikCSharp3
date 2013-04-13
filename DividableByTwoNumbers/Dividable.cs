using System;

    class Dividable
    {
        static void Main(string[] args)
        {
            bool canDivide = false;
            int someNumber;
            someNumber = int.Parse(Console.ReadLine());
            canDivide = (someNumber % 7 == 0) && (someNumber % 5 == 0);
            Console.WriteLine("THe number can be divided by 5 and 7 is "+canDivide);

        }
    }

