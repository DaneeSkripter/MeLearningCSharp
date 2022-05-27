using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter action (+, -, :, x): ");
            string action = Console.ReadLine();
            if (action == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (action == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (action == ":")
            {
                Console.WriteLine(num1 / num2);
            } else if (action == "x")
            {
                Console.WriteLine(num1 * num2);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Main();
        }
    }
}
