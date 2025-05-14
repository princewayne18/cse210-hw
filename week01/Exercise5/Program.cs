using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int SquaredNumber = SquareNumber(number);

        DisplayResult(name, SquaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name =Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string userNumber =Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number *number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
         Console.WriteLine($"{name}, the square of your number is {square}");
    }


}