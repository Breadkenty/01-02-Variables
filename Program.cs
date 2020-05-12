using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaring the variables for 1. Number of Coffee, 2. Full Name, 3. Today's Date.
            var numberOfCupsOfCoffee = 1;
            var fullName = "Kento Kawakami";
            var today = DateTime.Today;

            //Writes variables in a sentence inside of the console. 
            Console.WriteLine($"Hi I'm {fullName} and I drank {numberOfCupsOfCoffee} cup of coffee on {today.ToLongDateString()}.");

            //Asks user to input their name and declares it to userName.
            Console.WriteLine("What is your first name?");
            var userName = Console.ReadLine();
            //If the user's name happens to be "Alice" it triggers a special message.
            if (userName == "Alice")
            {
                Console.WriteLine($"Wow, THE {userName} from {userName} in Wonderland?!");
            }

            //If it's not Alice, then it proceeds with the default message.
            else
            {
                //Responds with a greeting with the inputted name.
                Console.WriteLine($"Hello {userName}!");
                Console.WriteLine("\n");
            }

            //Asks the user for two numbers.
            Console.WriteLine("Give me a number ");
            Console.WriteLine("\n");

            string firstNumberAsString = Console.ReadLine();

            Console.WriteLine("And another... ");
            Console.WriteLine("\n");
            string secondNumberAsString = Console.ReadLine();

            //Saves the answers into the variables firstOperand and secondOperand respectively.
            double firstOperand = Double.Parse(firstNumberAsString);
            double secondOperand = Double.Parse(secondNumberAsString);

            //Processes the numbers by adding, subtracting, multiplying, dividing, and finding the remainder of the numbers given.
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            //Writes the answers in the console.
            Console.WriteLine($"If you add {firstOperand} with {secondOperand}, you get {sum}.");
            Console.WriteLine($"If you subtract {firstOperand} with {secondOperand}, you get {difference}.");
            Console.WriteLine($"If you multiply {firstOperand} with {secondOperand}, you get {product}.");
            Console.WriteLine($"If you divide {firstOperand} with {secondOperand}, you get {quotient}.");
            Console.WriteLine($"The remainder of {firstOperand} with {secondOperand} is {remainder}.");

        }
    }
}
