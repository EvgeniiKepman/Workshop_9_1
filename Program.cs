// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());

Numbers(max);

void Numbers (int max)
{
    if (max == 0) 
        return;
    else 
        Console.Write($"{max}, ");
    Numbers (max - 1);
}
