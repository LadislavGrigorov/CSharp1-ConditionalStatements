using System;
//3. Write a program that finds the biggest of three integers using nested if statements.
class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if ((firstNumber >= secondNumber)&&(firstNumber >= thirdNumber))
        {
            Console.WriteLine("{0} is the biggest", firstNumber);
        }
        else if ((secondNumber >= firstNumber)&&(secondNumber >= thirdNumber))
        {
            Console.WriteLine("{0} is the biggest", secondNumber);
        }
        else if ((thirdNumber >= firstNumber) && (thirdNumber >= secondNumber))
        {
            Console.WriteLine("{0} is the biggest", thirdNumber);
        }
    }
}
