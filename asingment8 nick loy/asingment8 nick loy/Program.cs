using System;

namespace ConsoleApp6nickloy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type your first number then press enter");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("type your second number then press enter");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("type your third number then press enter");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("type your fourth number then press enter");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("type your fifth number then press enter");
            int number5 = int.Parse(Console.ReadLine());


            int positivecounter = 0;
            int negativecounter = 0;
            int zerocounter = 0;


            if (number1 > 0)
            {
                positivecounter = positivecounter + 1;
            }
            else if (number1 < 0)
            {
                negativecounter = negativecounter + 1;
            }
            else
            {
                zerocounter = zerocounter + 1;
            }


            if (number2 > 0)
            {
                positivecounter = positivecounter + 1;
            }
            else if (number2 < 0)
            {
                negativecounter = negativecounter + 1;
            }
            else
            {
                zerocounter = zerocounter + 1;
            }


            if (number3 > 0)
            {
                positivecounter = positivecounter + 1;
            }
            else if (number3 < 0)
            {
                negativecounter = negativecounter + 1;
            }
            else
            {
                zerocounter = zerocounter + 1;
            }


            if (number4 > 0)
            {
                positivecounter = positivecounter + 1;
            }
            else if (number4 < 0)
            {
                negativecounter = negativecounter + 1;
            }
            else
            {
                zerocounter = zerocounter + 1;
            }


            if (number5 > 0)
            {
                positivecounter = positivecounter + 1;
            }
            else if (number5 < 0)
            {
                negativecounter = negativecounter + 1;
            }
            else
            {
                zerocounter = zerocounter + 1;
            }

            Console.WriteLine($"there are {positivecounter} postive numbers");
            Console.WriteLine($"there are {negativecounter} negative numbers");
            Console.WriteLine($"there are {zerocounter} zeros");
        }
    }
}
