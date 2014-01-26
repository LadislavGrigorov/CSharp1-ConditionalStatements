using System;
//9.We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

class SumOfNumsIs0
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth integer number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", firstNumber, secondNumber);
        }
        else if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", firstNumber, thirdNumber);
        }
        else if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", firstNumber, fourthNumber);
        }
        else if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", secondNumber, thirdNumber);
        }
        else if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", secondNumber, fourthNumber);
        }
        else if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}=0", thirdNumber, fourthNumber);
        }
        else if (firstNumber  + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}{2:+#;-#}=0", firstNumber, secondNumber, thirdNumber);
        }
        else if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}{2:+#;-#}=0", firstNumber, secondNumber, fourthNumber);
        }
        else if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}{2:+#;-#}=0", secondNumber, thirdNumber, fourthNumber);
        }
        else if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}{2:+#;-#}=0", firstNumber, thirdNumber, fourthNumber);
        }
        else if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0}{1:+#;-#}{2:+#;-#}{3:+#;-#}=0", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
    }
}
