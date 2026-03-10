// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Поиск максимального элемента в массиве");
        
        int[] numbers = { 5, 3, 8, 1, 9, 12, 4 };
        
        Console.WriteLine("Исходный массив:");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("\n");
        
        int max = numbers[0]; 
        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i]; 
            }
        }
        
        Console.WriteLine($"Максимальный элемент в массиве: {max}");
        Console.WriteLine("Конец программы");
    }
}