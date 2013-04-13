using System;

    class ExchangeGivenBits
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter an integer: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter first bit position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter the lenght of the interval: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the first bit of the second interval's position: ");
            int q = int.Parse(Console.ReadLine());
            //creating masks with 1 in the positions that would be swapped
            uint firstBitsMask = (uint)(Math.Pow(2, k) - 1) << p;
            uint secondBitsMask = (uint)(Math.Pow(2, k) - 1) << q;
            //extracting the bits from the integer and moving them into their new positions in new variables
            uint firstBits = n & firstBitsMask;
            firstBits = firstBits << (q - p);
            uint secondBits = n & secondBitsMask;
            secondBits = secondBits >> (q - p);
            //creating a mask with 1 on the places of the both sequences of bits
            uint maskN1 = (uint)(Math.Pow(2, k) - 1) << p;
            uint maskN2 = (uint)(Math.Pow(2, k) - 1) << q;
            uint maskN = maskN1 | maskN2;
            //making those places 0 in the integer
            n = n & ~(maskN);
            //adding the extracted earlier bits
            n = n | firstBits;
            n = n | secondBits;

            Console.WriteLine(n);
        }
    }

