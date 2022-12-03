// Задача 1. По двум заданным числам проверить является ли первое число квадратом второго

int numberA = new Random().Next(5, 25);
int numberB = new Random().Next(1, 5);
Console.WriteLine("Первое число получилось такое:");
Console.WriteLine(numberA);
Console.WriteLine("Второе число получилось такое:");
Console.WriteLine(numberB);

if (numberA - numberB * numberB == 0)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
