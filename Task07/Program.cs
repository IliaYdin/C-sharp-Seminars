// 7. Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. и на выходе показывает последнюю цифру этого числа.
// 3. Вывод результата.

// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int nomber = Convert.ToInt32(Console.ReadLine());
int lastDigit = nomber % 10;
Console.Write($"{lastDigit}");