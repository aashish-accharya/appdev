
using System.Reflection.Metadata;
using week3;

Console.WriteLine("Enter 1 to Check Prime");
Console.WriteLine("Enter 2 to Check Odd Even");
Console.WriteLine("Enter 3 to Swap");
Console.WriteLine("Enter 4 to Search");
var choice = Convert.ToInt32(Console.ReadLine());

switch (choice){
    case 1:
        Console.WriteLine();
        Console.Write("Enter your number: ");
        var num = Convert.ToInt32(Console.ReadLine());
        Prime.CheckPrime(num);
        break;
    case 2:
        Console.WriteLine();
        Console.Write("Enter your number: ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        OddEven.CheckOddEven(num2);
        break;
    case 3:
        Console.WriteLine();
        Console.Write("Enter first number: ");
        var firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        var secondNum = Convert.ToInt32(Console.ReadLine());
        Swap.swap(firstNum, secondNum);
        break;
    case 4:
        Console.WriteLine();
        Console.Write("Enter your number to search through array: ");
        var searchNum = Convert.ToInt32(Console.ReadLine());
        Search.SearchVal(searchNum);
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}


