// Ashley Ondoua
// Section 4
// Mission #2 assignment-- dice throwing simulator
using HW1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome to the dice throwing simulator!
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        // Allow the user to choose how many times the “dice” will be thrown
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        int rollNumber = int.Parse(Console.ReadLine()); // Get user input for rollNumber

        // i want to connect to the other file (SecondClass)
        SecondClass sc = new SecondClass();
        // Do I need an instance of the second class?
        // SecondClass SecondClassInstance = new SecondClass();


        // Calling the method in SecondClass to pass the number of rolls
        int[] resultsArray = sc.rollingTheDice(rollNumber);

        // In the first class, use that array to print a histogram
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        // Total number of rolls
        System.Console.WriteLine("Total number of rolls = " + rollNumber);

        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage of times that number was rolled
            int percentage = (resultsArray[i] * 100) / rollNumber;

            // Print the number and the corresponding percentage as asterisks
            string asterisks = new string('*', percentage);
            Console.WriteLine(i + ": " + asterisks);
        }

        // Thank you for using the dice throwing simulator. Goodbye!
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
