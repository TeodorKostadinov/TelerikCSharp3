using System;

    class CheckThirdBit
    {
        static void Main(string[] args)
        {
            int someInteger;
            someInteger = int.Parse(Console.ReadLine());
            int bit=(((someInteger / 2) / 2) / 2) % 2;
            Console.WriteLine(" The bit is " +bit);
        }
    }

