using System;

class Program
{
    static void Main()
    {
        // print the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // prompt the user for the package weight
        Console.Write("Please enter the package weight: ");
        float weight = float.Parse(Console.ReadLine());

        // check if the weight exceeds 50
        if (weight > 50)
        {
            // print error message and exit the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // prompt the user for the package dimensions
        Console.Write("Please enter the package width: ");
        float width = float.Parse(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        float height = float.Parse(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        float length = float.Parse(Console.ReadLine());

        // calculate the total dimensions
        float totalDimensions = width + height + length;

        // check if the total dimensions exceed 50
        if (totalDimensions > 50)
        {
            // print error message and exit the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // calculate the quote
        float quote = (width * height * length * weight) / 100;

        // print the quote to the user
        Console.WriteLine("Your estimated total for shipping this package is: ${0:F2}", quote);
        Console.WriteLine("Thank you!");
    }
}
