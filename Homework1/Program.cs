using System;
using System.Text.RegularExpressions;


namespace Homework1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Print what Task the user are in and call for the task method
            Console.WriteLine("\n\tTask 1 \n");
            Task1();
            Console.WriteLine("\n\n\tTask 2 \n");
            Task2();
            Console.WriteLine("\n\n\tTask 3 \n");
            Task3();
            Console.WriteLine("\n\n\tTask 4 \n");
            Task4();
            Console.WriteLine("\n\n\tTask 5 \n");
            Task5();
            Console.WriteLine("\n\n\tTask 6 \n");
            Task6();
            Console.WriteLine("\n\n\tTask 7 \n");
            Task7();
            Console.WriteLine("\n\tTask 8 \n");
            Task8();

            //Write what user need to to to exit program
            Console.WriteLine("\nPress RETURN to Quit the program.");
            //User input return quits the program 
            if (Console.ReadKey(true).Key != ConsoleKey.Enter) { System.Environment.Exit(1); }

        }
        public static void Task1()
        {         
            //Declare and initialize two string variables
            string firstString;
            string secondString;
            

            //Ask for user input value and assig it too string varibles
            Console.WriteLine("Please enter the first string:");
            firstString = Console.ReadLine();

            Console.WriteLine("Please enter the second string:");
            secondString = Console.ReadLine();

            //Add the tow string together and display the result to user
            Console.WriteLine($"The resualt is: {firstString}{secondString}");

            //Write what user need to do to exit task 1 and continue
            Console.WriteLine("Press RETURN to Quit.");
            //User input return quits the task 1
            if (Console.ReadKey(true).Key != ConsoleKey.Enter) { System.Environment.Exit(1); }

        }
        public static void Task2()
        {
             //Ask for user input
            Console.WriteLine("Please enter a number:");

            /* Check, declare and initialize a integer and convert the string representation
            of the number to its single int-point number equivalent */
            string input = (Console.ReadLine());
            int number = int.Parse(CheckIfOnlyDigits(input));


            //Check if number is even and display the resualt for user
            if ( number % 2 == 0)
            {
                Console.WriteLine("The number you have enterd is even.");
            }
            else
            {
                Console.WriteLine("The number you have enterd is odd.");
            }

        }
        public static void Task3()
        {
            //Declare and initialize three float variables
            float firstNum = 0, secondNum = 0, thirdNum = 0;

            //Ask for user input value and check if the input is only digits
            //Convert the string representation of the number to its single floating-point number equivalent
            Console.WriteLine("Enter the first number?");
            string input = (Console.ReadLine());
            firstNum = float.Parse(CheckIfOnlyDigits(input));

            Console.WriteLine("Enter the second number?");
            input = (Console.ReadLine());
            secondNum = float.Parse(CheckIfOnlyDigits(input));

            Console.WriteLine("Enter the third number?");
            input = (Console.ReadLine());
            thirdNum = float.Parse(CheckIfOnlyDigits(input));

            //Display the result
            Console.WriteLine($"{firstNum}\t {secondNum}\t {thirdNum}");

        }
        public static void Task4()
        {
            //Display T with T
            Console.WriteLine("\tTTTTTTTTT");
            Console.WriteLine("\t    T    ");
            Console.WriteLine("\t    T    ");
            Console.WriteLine("\t    T    ");
            Console.WriteLine("\t    T    \n");
            //Display B with B
            Console.WriteLine("\tBBBBBBBB ");
            Console.WriteLine("\tB       B");
            Console.WriteLine("\tBBBBBBBB ");
            Console.WriteLine("\tB       B");
            Console.WriteLine("\tBBBBBBBB ");
        }
        public static void Task5()
        {
            //Declare and initialize two int variables
            int x = 0, y = 0;

            //Ask for user input value and check if the input is only digits
            //Convert the string representation of the number to its single int-point number equivalent
            Console.WriteLine("Enter the x value?");
            string input = (Console.ReadLine());
            x = int.Parse(CheckIfOnlyDigits(input));
            
            Console.WriteLine("Enter the y value?");
            input = (Console.ReadLine());
            y = int.Parse(CheckIfOnlyDigits(input));

            //Display the result and calculate
            Console.WriteLine($"The sum of xValue with yValue is {x + y}");
            Console.WriteLine($"The difference of xValue with yValue is {x - y}");
            Console.WriteLine($"The product of xValue with yValue is {x * y}");
            Console.WriteLine($"The division of xValue with yValue is {x / y}");
            Console.WriteLine($"The remainder of xValue with yValue is {x % y}");
        }
        public static void Task6()
        {
            //Ask for user input value and check if the input is only digits
            //Convert the string representation of the number to its single int-point number equivalent
            Console.WriteLine("Please enter the circle radius:");
            string input = (Console.ReadLine());
            int r = int.Parse(CheckIfOnlyDigits(input));

            //Display the result and calculate
            Console.WriteLine($"Diameter= {2 * r}");
            Console.WriteLine($"Circumference= {2 * Math.PI * r}");
            Console.WriteLine($"Area= {Math.PI * (r * r)}");
        }
        public static void Task7()
        {
            //Ask for user input value and check if the input is 4 digits
            //Convert the string representation of the number to its single int-point number equivalent
            Console.WriteLine("Please enter four digits:");
            string input = (Console.ReadLine());

            while ( input.Length != 4)
            {
                Console.WriteLine("\nPleas enter 4 digits");
                input = Console.ReadLine();
                input = CheckIfOnlyDigits(input);

            }

            int digits = int.Parse(CheckIfOnlyDigits(input));

            //Pick of the numbers and display the resualt
            Console.WriteLine($"{digits / 1000}\t{(digits % 1000) / 100}\t{(digits % 100) / 10}\t{digits % 10}");
        }
        public static void Task8()
        {
            //Ask for user input value and check if the input is only digits
            //Convert the string representation of the number to its single int-point number equivalent
            Console.WriteLine("Please enter a number:");
            string input = (Console.ReadLine());
            int number = int.Parse(CheckIfOnlyDigits(input));

            //Calculate and display the resualt
            Console.WriteLine("number \tsquare \tcube");
            Console.WriteLine($"{number} \t{number * number} \t{number * number * number}");

        }
        private static string CheckIfOnlyDigits(string input)
        {
            //Checks if input only contains digits and ask for a new input until it only contains digits
            while (!Regex.IsMatch(input, "^[0-9]+$"))
            {
                    Console.WriteLine("\nPleas try again to enter the requested input");
                    input = Console.ReadLine();
                    
            }
            return input;

        }


    }
}
