﻿// // 0. Демонстрация решения

// // Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдаёт его квадрат (число умноженное на само себя).
// 3. Вывод результата

// // Например:
// // 4 -> 16
// // -3 -> 9
// // -7 -> 49

Console.WriteLine("Введите целое число: ");
int nomber = Convert.ToInt32(Console.ReadLine()); // 34554634
int square = nomber * nomber; 
Console.WriteLine($"Квадрат числа {nomber} = {square}");