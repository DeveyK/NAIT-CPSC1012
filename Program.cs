using System.Runtime.InteropServices;

namespace Assignment1_DKohli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string userInput;
            Console.Write("Please enter target amount");
            userInput = Console.ReadLine(); 
            num1 = int.Parse(userInput);

            Console.WriteLine("The target amount is: " +  num1);

            Console.WriteLine("Please enter Annual interest (percentage) ");
            double num2 = double.Parse(Console.ReadLine());
            int num3;
            num3 = 12;
            double quotient = (double) num2 / num3;
            Console.WriteLine($" The Quotient of {num2} and {num3} is {quotient}");

            Console.WriteLine($" The monthly interest rate is {quotient}");

            Console.Write("Please enter the amount of years you would like to save");
            int num4 = int.Parse(Console.ReadLine());
            int product = num4 * num3;
            Console.WriteLine($"The amount of contriubtions made over two years is {num4 * num3}");

            double sum = Math.Pow(quotient + 1, product - 1);
            double product2 = quotient * num1;
            double quotient2 = (double) product2 / sum;
            Console.WriteLine($"The monthly contribution amount over two years is {quotient2}"); 
            
            













        }
    }
}



    
        

        
    