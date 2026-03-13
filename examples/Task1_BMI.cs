using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите ваш вес (кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите ваш рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            double bmi = weight / (height * height);
            
            string category = "";
            string recommendation = "";
            
            if (bmi < 18.5)
            {
                category = "Недостаточный вес";
                recommendation = "Рекомендуется улучшить питание";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                category = "Нормальный вес";
                recommendation = "Отлично! Так держать!";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                category = "Избыточный вес";
                recommendation = "Рекомендуется больше двигаться";
            }
            else if (bmi >= 30)
            {
                category = "Ожирение";
                recommendation = "Рекомендуется обратиться к врачу";
            }
            else
            {
                category = "Ошибка";
                recommendation = "Некорректные данные";
            }
            
            Console.WriteLine("\n=== РЕЗУЛЬТАТ ===");
            Console.WriteLine($"Ваш ИМТ: {bmi:F2}");
            Console.WriteLine($"Категория: {category}");
            Console.WriteLine($"Рекомендация: {recommendation}");
            
        }
    }
}