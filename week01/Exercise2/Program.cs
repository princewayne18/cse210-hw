using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);

        if (gradeNumber>=90)
        {
            Console.WriteLine("A");
        }

        else if (gradeNumber>=80)
        {
            Console.WriteLine("B");
        }

        else if (gradeNumber>=70)
        {
            Console.WriteLine("C");

        }
        else if(gradeNumber>=60)
        {
            Console.WriteLine("D");

        }
        else
        {
           Console.WriteLine("F"); 
        }
        
    if (gradeNumber>=70)
    {
        Console.WriteLine("Cogradulation you passed your exams!!!!!!");
    }
    else
    {
        Console.WriteLine("Unfortunately you failed your exam, try again next time");
    }
    }
}