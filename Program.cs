using System;

namespace _02_Variables
{
    class Program
    {


        static void welcomeMessage()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("-----------Howdy------------");
            Console.WriteLine("----------------------------");
        }


        //Method for asking a question for an answer with strings.
        static string promptForString(string prompt)
        {
            Console.WriteLine(prompt);
            var stringAnswer = Console.ReadLine();

            return stringAnswer;
        }

        //My attempt at while looping this method. For some reason I can't get the intAnswer to convert to a string.

        // static int promptForInt(string prompt)
        // {
        //     Console.WriteLine(prompt);
        //     int intAnswer;
        //     var correctInput = Int32.TryParse(Console.ReadLine(), out intAnswer);

        //     while (correctInput != true)
        //     {
        //         Console.WriteLine("I said number you dingus");
        //         var correctInput2 = Int32.TryParse(Console.ReadLine(), out intAnswer);

        //         if (correctInput2 == true)
        //         {
        //             return intAnswer;
        //         }
        //     }


        //     return intAnswer;

        // }

        static void Main(string[] args)
        {

            // ----------------------------------------

            //Display welcome message using the method
            welcomeMessage();

            //Declaring the variables for 1. Number of Coffee, 2. Full Name, 3. Today's Date.
            var numberOfCupsOfCoffee = 1;
            var fullName = "Kento Kawakami";
            var today = DateTime.Today;


            //Writes variables in a sentence inside of the console. 
            Console.WriteLine($"Hi I'm {fullName} and I drank {numberOfCupsOfCoffee} cup of coffee on {today.ToLongDateString()}.");


            //Asks user to input their name and declares it to userName.
            var firstName = promptForString("What is your first name?");


            //If the user's name happens to be "Alice" it triggers a special message.
            if (firstName == "Alice")
            {
                Console.WriteLine($"Wow, THE {firstName} from {firstName} in Wonderland?!");
            }

            //If it's not Alice, then it proceeds with the default message.
            else
            {
                //Responds with a greeting with the inputted name.
                Console.WriteLine($"Hello {firstName}!");
                Console.WriteLine("\n");
            }

            // Asks the user for two numbers.
            var firstNumberAsString = promptForString("Give me a number ");
            Console.WriteLine("\n");


            var secondNumberAsString = promptForString("And another... ");
            Console.WriteLine("\n");

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



            //---------------------------------------------



        }

    }
}
