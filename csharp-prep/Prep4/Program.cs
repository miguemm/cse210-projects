using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        List<int> numbers = new();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter number:");
            input  = int.Parse(Console.ReadLine());

            if (input != 0)
            {
            numbers.Add(input);
            }

        } while (input != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

        numbers.Sort();

        Console.WriteLine("Sorted List:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}