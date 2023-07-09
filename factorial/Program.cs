using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("factorial calculating");
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            int counter = 1;

            while (counter <= num)
            {
                factorial *= counter;
                counter++;
            }

            Console.WriteLine("The factorial of " + num + " is: " + factorial);
        }
   
}