// Задача 2 определить максимальное и минимальное число

int numberA = new Random().Next(1, 1000);
int numberB = new Random().Next(1, 1000);
Console.WriteLine("Первое число");
Console.WriteLine(numberA);
Console.WriteLine("Второе число");
Console.WriteLine(numberB);

if (numberA > numberB)
{
    Console.WriteLine("Максимальное");
    Console.WriteLine(numberA);
    Console.WriteLine("Минимальное");
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine("Максимальное");
    Console.WriteLine(numberB);
    Console.WriteLine("Минимальное");
    Console.WriteLine(numberA);
}
