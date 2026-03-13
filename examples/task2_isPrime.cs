using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            bool isPrime = IsPrime(number);
            
            if (isPrime)
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым");
            }
            
        }
        

        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false; 
            }
            
            if (n == 2)
            {
                return true; 
            }
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}