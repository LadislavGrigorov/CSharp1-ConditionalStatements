using System;
//4.Sort 3 real values in descending order using nested if statements.

class Sort3RealValues
{
    static void Main()
    {
        Console.Write("Enter first value: ");
        decimal firstValue = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        decimal secondValue = decimal.Parse(Console.ReadLine());
        Console.Write("Enter third value: ");
        decimal thirdValue = decimal.Parse(Console.ReadLine());
        if ((firstValue > secondValue) && (secondValue >= thirdValue))
	    {
		    Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);
	    }
        else if ((firstValue > secondValue) && (thirdValue >= secondValue))
        {
            Console.WriteLine(firstValue);
            Console.WriteLine(thirdValue);
            Console.WriteLine(secondValue);
        }
        else if ((secondValue > firstValue) && (firstValue >= thirdValue))
	    {
            Console.WriteLine(secondValue);
            Console.WriteLine(firstValue);
            Console.WriteLine(thirdValue);
	    }
        else if ((secondValue > thirdValue) && (thirdValue >= firstValue))
        {
            Console.WriteLine(secondValue);
            Console.WriteLine(thirdValue);
            Console.WriteLine(firstValue);
        }
        else if ((thirdValue > firstValue) && (firstValue >= secondValue))
        {
            Console.WriteLine(thirdValue);
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
        }
        else if ((thirdValue > firstValue) && (secondValue >= firstValue))
        {
            Console.WriteLine(thirdValue);
            Console.WriteLine(secondValue);
            Console.WriteLine(firstValue);
        }
    }
}
