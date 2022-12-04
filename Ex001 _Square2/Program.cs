// Задача 1. По двум заданным числам проверить является ли первое число квадратом второго

Console.Write("введите число и нажмите Enter\t");
int numberA = int.Parse(Console.ReadLine());
Console.Write("введите число и нажмите Enter\t");
int numberB = int.Parse(Console.ReadLine());


if (numberA - numberB * numberB == 0)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
