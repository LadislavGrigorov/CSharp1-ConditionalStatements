using System;
//2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

class SignOfProductOf3
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if ((firstNumber==0) || (secondNumber==0) || (thirdNumber==0))
        {
            Console.WriteLine("One of the numbers is 0!");
        }
        else if ((firstNumber<0)&&((secondNumber > 0) && (thirdNumber > 0)))
        {
            Console.WriteLine("Sign of the product is -");
        }
        else if ((secondNumber<0)&&((firstNumber > 0) && (thirdNumber > 0)))
        {
            Console.WriteLine("Sign of the product is -");
        }
        else if ((thirdNumber<0)&&((firstNumber > 0) && (secondNumber > 0)))
        {
            Console.WriteLine("Sign of the product is -");
        }
        else if ((firstNumber<0)&&(secondNumber<0)&&(thirdNumber<0))
        {
            Console.WriteLine("Sign of the product is -");
        }
        else
        {
            Console.WriteLine("Sign of the product is +");
        }
    }
}
