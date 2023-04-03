using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {

            Console.WriteLine("Enter first number"); ;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
           Console.WriteLine(num1 + num2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine("Enter second number");
    }

    static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
}