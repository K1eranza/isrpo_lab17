using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.Write("Ваш выбор: ");
            
            string choice = Console.ReadLine();
            double result = 0;
            
            if (choice == "1")
            {
                result = Add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (choice == "2")
            {
                result = Subtract(num1, num2);
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (choice == "3")
            {
                result = Multiply(num1, num2);
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else if (choice == "4")
            {
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: делить на ноль нельзя!");
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор операции!");
            }
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        
        static double Add(double a, double b)
        {
            return a + b;
        }
        
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}