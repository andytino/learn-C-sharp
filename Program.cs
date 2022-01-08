using System;

namespace HelloWorld
{
    class Program
    {
        static bool checkNumber(string? strInput)
        {
            double number;
            if (Double.TryParse(strInput, out number))
            {
                Console.WriteLine(number);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is outside the range of a Double.", strInput);
                return false;
            }
        }
        static void Add(string? a, string? label)
        {
            bool isNumber = checkNumber(a);
            if (!isNumber)
            {
                Console.Write($"Nhap {label}: ");
                a = Console.ReadLine();
                Add(a, "a");
            }
        }
        static void Main(string[] args)
        {
            string? a, b;
            Console.Write("Nhap a: ");
            a = Console.ReadLine();
            Add(a, "a");
            Console.Write("Nhap b: ");
            b = Console.ReadLine();
            Add(b, "b");

        }
    }
}