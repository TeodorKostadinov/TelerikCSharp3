using System;

    class OddOrEven
    {
        static void Main(string[] args)
        {
            bool isEven = false;
            int someInteger;
            someInteger=int.Parse(Console.ReadLine());
            isEven = (someInteger % 2 == 0);
            Console.WriteLine("This is an even number - "+isEven);
        }
    }

