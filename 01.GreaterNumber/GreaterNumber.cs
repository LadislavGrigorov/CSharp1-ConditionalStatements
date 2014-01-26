using System;
//1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Numbers are equal");
        }
        else    if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber + secondNumber;           //Exchanging values if first number > second
                    secondNumber = firstNumber - secondNumber;
                    firstNumber = firstNumber - secondNumber;
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }
                else if (secondNumber > firstNumber)
                {
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }
    }
}
