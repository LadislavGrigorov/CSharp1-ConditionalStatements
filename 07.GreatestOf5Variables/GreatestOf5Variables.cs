using System;
//7. Write a program that finds the greatest of given 5 variables.
class GreatestOf5Variables
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());
        if ((firstNumber>=secondNumber)&&(firstNumber>=thirdNumber)&&(firstNumber>=fourthNumber)&&(firstNumber>=fifthNumber))
        {
            Console.Write("The greatest number is ");
            Console.WriteLine(firstNumber);
        } 
        else if ((secondNumber>=firstNumber)&&(secondNumber>=thirdNumber)&&(secondNumber>=fourthNumber)&&(secondNumber>=fifthNumber))
        {
            Console.Write("The greatest number is ");
            Console.WriteLine(secondNumber);
        }
        else if ((thirdNumber>=firstNumber)&&(thirdNumber>=secondNumber)&&(thirdNumber>=fourthNumber)&&(thirdNumber>=fifthNumber))
        {
            Console.Write("The greatest number is ");
            Console.WriteLine(thirdNumber);
        } else if ((fourthNumber>=firstNumber)&&(fourthNumber>=secondNumber)&&(fourthNumber>=thirdNumber)&&(fourthNumber>=fifthNumber))
        {
            Console.Write("The greatest number is ");
            Console.WriteLine(fourthNumber);
        }
        else if ((fifthNumber>=firstNumber)&&(fifthNumber>=secondNumber)&&(fifthNumber>=thirdNumber)&&(fifthNumber>=fourthNumber))
        {
            Console.Write("The greatest number is ");
            Console.WriteLine(fifthNumber);
        }
    }
}
