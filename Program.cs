// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите первое число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int max = Convert.ToInt32(Console.ReadLine()); ;
SumNumbers(min, max);
System.Console.WriteLine($"\nСумма всех натуральных элементов от {min} до {max} : {SumNumbers(min, max)}");

int SumNumbers(int min, int max)
{
    if (min > max) return 0;
    return min + SumNumbers(min + 1, max);
}