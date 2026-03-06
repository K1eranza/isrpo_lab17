Console.WriteLine("Выбор одежды по погоде");
Console.WriteLine("Введите текущую температуру (°C): ");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature >= 20)
{
    Console.WriteLine("Наденьте лёгкую одежду");
}
else
{
    Console.WriteLine("Наденьте тёплую одежду");
}

Console.WriteLine("Хорошего дня!");