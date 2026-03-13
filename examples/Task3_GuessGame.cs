using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Компьютер загадал число от 1 до 100");
            
            Random random = new Random();
            
            bool playAgain = true;
            
            while (playAgain)
            {
                int Number = random.Next(1, 101);
                int guess = 0;
                int attempts = 0;
                                
                while (guess != Number)
                {
                    Console.Write("Введите ваше число: ");
                    
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                        
                        if (guess < Number)
                        {
                            Console.WriteLine("Загаданное число больше");
                        }
                        else if (guess > Number)
                        {
                            Console.WriteLine("Загаданное число меньше");
                        }
                        else
                        {
                            Console.WriteLine($"\nВы угадали число {Number}!");
                            Console.WriteLine($"Количество попыток: {attempts}");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                    }
                }
                
                Console.Write("\nХотите сыграть ещё? (да/нет): ");
                string answer = Console.ReadLine().ToLower();
                
                if (answer != "да" && answer != "yes" && answer != "y")
                {
                    playAgain = false;
                }
            }
            
            Console.WriteLine("\nдо свидания!");
        }
    }
}