using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Hi {firstName}! What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your quest?");
            string theQuest = Console.ReadLine();

            Console.WriteLine("What is your parish?");
            string yourParish = Console.ReadLine();

            Console.WriteLine($"OK, {firstName}, your favorite color is {favColor}.");
            Console.WriteLine($"And your quest: {theQuest}.");
            Console.WriteLine($"And on Sunday, you will be attending {yourParish} for Mass.");
            Console.WriteLine();

            Console.WriteLine("Now, let's do some math.");
            int firstNum = 3;
            int secondNum = 4;

            int newSum = Add(firstNum, secondNum);
            Console.WriteLine($"The sum of the numbers is {newSum}.");

            int newProduct = Multiply(firstNum, secondNum);
            Console.WriteLine($"The product of the two numbers is {newProduct}.");

            Console.WriteLine();
            Console.WriteLine("Challenge Mode!");
            int thirdNum = 5;
            int fourthNum = 6;
            int fifthNum = 7;
            int newSum3 = Add(firstNum, secondNum, thirdNum);
            Console.WriteLine($"Sum of three numbers: {newSum3}");
            int newSum5 = Add(firstNum, secondNum, thirdNum, fourthNum, fifthNum);
            Console.WriteLine($"Sum of five numbers: {newSum5}");

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static int Add(int x, int y, int z, int a, int b)
        {
            return x + y + z + a + b;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
