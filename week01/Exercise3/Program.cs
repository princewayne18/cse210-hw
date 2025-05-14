using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your Guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
            
        }

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        guess = -1;



         while (guess != randomNumber)
        {
            Console.Write("What is your Guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }

    }
}