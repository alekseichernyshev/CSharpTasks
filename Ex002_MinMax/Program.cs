// Задача 2 определить максимальное и минимальное число

Console.Write("введите число и нажмите Enter\t");
int numberA = int.Parse(Console.ReadLine());
Console.Write("введите число и нажмите Enter\t");
int numberB = int.Parse(Console.ReadLine());


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
