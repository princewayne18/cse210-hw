using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int number =-1;

         Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number!=0)
        {
           
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number= int.Parse(userNumber);

            if (number !=0)
            {
                numbers.Add(number);
            }
 
        }

        //suming up each item in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum +=num;
        }
        float average = (float)sum /numbers.Count;

        //calculation of Max
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}