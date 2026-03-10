using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вывод элементов массива");

        int[] numbers = { 5, 3, 8, 1, 9 };

        Console.WriteLine("Элементы массива:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Элемент [{i}] = {numbers[i]}");
        }

        Console.WriteLine("\nВывод с использованием foreach:");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        Console.WriteLine("\nКонец программы");
    }
}
//test