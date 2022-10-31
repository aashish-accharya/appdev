// See https://aka.ms/new-console-template for more information
using week1;

Console.WriteLine("Press 1 for Addition, 2 for Substraction, 3 for Multiplication, 4 for Division");
var choice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 1st number: ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
var num2 = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        calc.Addition(num1, num2);
        break;
    case 2:
        calc.Substraction(num1, num2);
        break;
    case 3:
        calc.Multiply(num1, num2);
        break;
    case 4:
        calc.Division(num1, num2);
        break;
    default:
        Console.WriteLine("Wrong Input Please Try again");
        break;
} 
