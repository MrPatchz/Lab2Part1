/// Chapter No. 2		Exercise No. 1
/// File Name: Lab2Part1.cs
/// @author: Jacques Zwielich 
/// Date:  September 07, 2020
///
/// Problem Statement: Ask the user to enter two numbers, calculate the sum of
/// these two numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for two integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lab2Part2
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Please enter three numbers:");

            // declare two integer variables
            int n1, n2, n3, sum, product;
            float division;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            userInput = Console.ReadLine();
            n2 = Int32.Parse(userInput);
            userInput = Console.ReadLine();
            n3 = Int32.Parse(userInput);

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            division = (float)product / sum;


            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("\nThe product of those three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("\nThe produce divided by the sum is ");
            Console.WriteLine(division);


            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}