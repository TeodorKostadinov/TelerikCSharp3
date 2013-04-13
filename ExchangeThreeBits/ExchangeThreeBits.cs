using System;

    class ExchangeThreeBits
    {
        static void Main(string[] args)
        {
            //entering the integer
            int n = int.Parse(Console.ReadLine());
            
            //making a mask for the first three bits ->  00000011100
            int maskFirstThree = 7 << 3;
  
            //making a mask for the second pair of bits -> 00111000000
            int maskSecondThree = 7 << 24;
            
            //extracting the first three bits from the integer with the mask
            int firstThree = n & maskFirstThree;

            //moving the extracted bits to 24,25 and 26th position
            firstThree = firstThree << 21;

            //the same for the second three bits
            int secondThree = n & maskSecondThree;
            secondThree = secondThree >> 21;

            //creating a mask with 1s on the places where the changed bits would be
            int maskN1 = 7 << 24;
            int maskN2 = 7 << 3;
            int maskN = maskN1 | maskN2;

            //replacing the bits in the integer where the changed bits would go with 0s
            n = n & ~(maskN);
            
            //combining the integer with the extracted bits
            n = n | firstThree;
            n = n | secondThree;
            Console.WriteLine(n);
        }
    }

