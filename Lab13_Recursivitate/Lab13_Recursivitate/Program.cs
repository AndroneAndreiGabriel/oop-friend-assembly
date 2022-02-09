using System;

namespace Lab13_Recursivitate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5 };
            int element = 5;
            int index = RecursivityHelper.IndexOfElement(element, array);
            Console.WriteLine($"Element {element} found at index: {index}");
        }

        private static void Example_Factorial()
        {
            int n = 5;
            int result = RecursivityHelper.Factorial(n);
            Console.WriteLine($"Factorial({n}) = { result}");
        }

        private static void Example_PrintArray()
        {
            RecursivityHelper.PrintArray(new [] { 1, 2, 3, 4, 5 });
        }

        private static void Example_Fibonacci()
        {
            int n = 6;
            long result = RecursivityHelper.Fibonacci(n);
            Console.WriteLine($"Fibonacci({n}): {result}");
            Console.WriteLine($"Fibonacci({n}) calculated in {RecursivityHelper.fiboCallCount} steps.");
        }
    }
}

