using System;
//8.Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

class UserVar
{
    static void Main(string[] args)
    {
        Console.Write("Please enter number or text: ");
        var userInput = Console.ReadLine();
        double number;
        int userCase;
        bool doubleInt = double.TryParse(userInput, out number);
        string isString = userInput;
        if (doubleInt)
        {
            userCase = 1;
        }
        else
        {
            userCase = 2;
        }
        switch (userCase)
        {
            case 1:
                Console.WriteLine(number +1);
                break;
            case 2:
                Console.WriteLine(isString+"*");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}
