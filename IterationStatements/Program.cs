using System.Reflection;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below



        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //ThousandNumber();

            //DivdeByThree();

            //EqualIntegers(2, 9);

            //EvenOrOdd(8);

            //PositiveOrNegative(-6);

            //AgeToVote();

            //NegTenToTen();

            MultiTable();
        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandNumber()
        {
            for (int num1 = 1000; num1 >= -1000; num1--)
            {
                Console.WriteLine(num1);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void DivdeByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualIntegers(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void AgeToVote()
        {
            Console.WriteLine("Please enter your age.");


            bool age = int.TryParse(Console.ReadLine(), out int number);

            if (number >= 18)
            {
                Console.WriteLine("Congrats! You can vote!");
            }
            else
            {
                Console.WriteLine("Sorry, please come back when you are at least 18 years old.");
            }
        }
        //Heating up
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void NegTenToTen()
        {
            Console.WriteLine("Please enter a number.");
            int userNum = int.Parse(Console.ReadLine());


            if (userNum <= 10 && userNum >= -10)
            {
                Console.WriteLine("Congrats!");
            }
            else
            {
                Console.WriteLine("Sorry. That was wrong.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            
            Console.WriteLine("Please enter a number.");

            int userNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * userNum);
            }
        }

    }
}
