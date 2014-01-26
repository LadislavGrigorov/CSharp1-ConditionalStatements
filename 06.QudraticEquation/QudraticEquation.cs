using System;

class QudraticEquation
{
    static void Main()
    {
        Console.WriteLine("ax\u00B2 + bx + c = 0");
        Console.Write("Enter a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        decimal c = decimal.Parse(Console.ReadLine());
        decimal discriminant = b * b - 4 * a * c;
        decimal root1;
        decimal root2;
        if (discriminant<0)
        {
            Console.WriteLine("There are no real roots");
        }
        if ((discriminant==0)&&(a!=0))
        {
            root1 = -b / (2 * a);
            Console.WriteLine("There is one real root X\u2081 = {0:0.00}", root1);
        }
        if ((discriminant>0)&&(a!=0))
        {
            double sqrtDiscriminant = Math.Sqrt((double)discriminant);
            root1=(((-b + (decimal)sqrtDiscriminant) / (2 * a)));
            root2 = (((-b - (decimal)sqrtDiscriminant) / (2 * a)));
            Console.WriteLine("There are two real roots X\u2081 = {0:0.00} and X\u2081 = {1:0.00}", root1, root2);
        }
        if (a==0)
        {
            root1 = (-c) / b;
            Console.WriteLine("The equation is linear and there is one root X\u2081 = {0:0.00}", root1);
        }
    }
}
