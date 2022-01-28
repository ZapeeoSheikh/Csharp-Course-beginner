using System;
using ConsoleApp1;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator mymath = new Calculator();

            Console.WriteLine("Outputs: ");
            Console.WriteLine($"The Sum of 8.2 and 4.2 is {mymath.Sum(8.2, 4.2)}");
            Console.WriteLine($"The Substraction of 8.2 and 4.2 is {mymath.Sub(8.2,4.2)}");
            Console.WriteLine($"The Multiplication of 8.2 and 4.2 is {mymath.Mul(8.2,4.2)}");
            Console.WriteLine($"The Division of 8.2 and 4.2 is {mymath.Div(8.2,4.2)}");

            
            //Muhammad Rameez 
            //Course: Asp.Net by mentorsh
            //Assignment 06
        }
    }
}

/*1. Make class "Calculator"
  2. Create functions Sum, Subtract, Divide, Multiply with return type double.
  3. Use double for parameters and results.*/