using System;

class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int counter = 0;


            for (int div = 1; div < number; div++)
            {
                if (number % div == 0)
                {
                    counter += div;
                }
            }

            if (counter == number)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not A Perfect Number");
            }
        }
      }
  }