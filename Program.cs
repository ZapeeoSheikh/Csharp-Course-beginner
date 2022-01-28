// See https://aka.ms/new-console-template for more information


int num1 = 20;
int num2 = 10;

int add = num1 + num2;
int sub = num1 - num2;
int div = num1 / num2;
int mul = num1 * num2;
int mod = num1 % num2;

Console.WriteLine($"The Sum of {num1} and {num2} is {add}");
Console.WriteLine($"The Diffrence of {num1} and {num2} is {sub}");
Console.WriteLine($"The Quotient of {num1} and {num2} is {div}");
Console.WriteLine($"The Product of {num1} and {num2} is {mul}");
Console.WriteLine($"The Remainder of {num1} and {num2} is {mod}");

if (num1 % 2 == 0)
{
    Console.WriteLine($"{num1} is an Even Number ");
    if (num2 % 2 == 0)
    {
        Console.WriteLine($"{num2} is also an Even Number ");
    }
    else
        Console.WriteLine($"However, {num2} is a Odd Number ");
}
else
{
    Console.WriteLine($"{num1} is a Odd Number ");
    if (num2 % 2 == 0)
    {
        Console.WriteLine($"However, {num2} is an Even Number ");
    }
    else
        Console.WriteLine($"{num2} is also a Odd Number ");
}

if (num1 % 2 == 0 && num2 % 2 == 0)
{
    Console.WriteLine("\n\nHello, World!");
    Console.WriteLine("You are Lucky");

}
// Console is not recording in this video 
// Muhammad Rameez 
