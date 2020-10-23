using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Hi {firstName}! What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your quest?");
            string theQuest = Console.ReadLine();

            Console.WriteLine("What is your parish?");
            string yourParish = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"OK, {firstName}, your favorite color is {favColor}.");
            Console.WriteLine($"And your quest: {theQuest}.");
            Console.WriteLine($"And on Sunday, you will be attending {yourParish} for Mass.");
            Console.WriteLine($"Will you be wearing your {favColor} shirt? Ha ha!");
            Console.WriteLine($"I trust that {yourParish} is helping in {theQuest}.");
            Console.WriteLine();

            // Exercise 2
            Console.WriteLine("Now, let's do some math.");
            Console.WriteLine("First number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int newSum = Add(firstNum, secondNum);
            Console.WriteLine($"The sum of the numbers is {newSum}.");

            int newProduct = Multiply(firstNum, secondNum);
            Console.WriteLine($"The product of the two numbers is {newProduct}.");

            Console.WriteLine();
            Console.WriteLine("Challenge Mode!");

            Console.WriteLine("Third number:");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth number:");
            int fourthNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fifth number:");
            int fifthNum = Convert.ToInt32(Console.ReadLine());
            int newSum3 = Add(firstNum, secondNum, thirdNum);
            Console.WriteLine($"Sum of three numbers: {newSum3}");
            int newSum5 = Add(firstNum, secondNum, thirdNum, fourthNum, fifthNum);
            Console.WriteLine($"Sum of five numbers: {newSum5}");

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        // Overloaded method for 3 inputs
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        // Overloaded method for 5 inputs
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
