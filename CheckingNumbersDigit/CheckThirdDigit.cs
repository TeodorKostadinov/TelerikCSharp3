using System;

    class CheckThirdDigit
    {
        static void Main(string[] args)
        {
            int someInteger;
            bool isItTrue;
            someInteger = int.Parse(Console.ReadLine());
            isItTrue = (someInteger / 100) % 10 == 7;
            Console.WriteLine("The tird digit is seven is "+isItTrue);
        }
    }

