// 4. Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. и выдаёт максимальное из этих чисел.
// 3. Вывод результата.

// Пример:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите число1: ");
int nomber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int nomber2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число3: ");
int nomber3 = Convert.ToInt32(Console.ReadLine());

int max = nomber1;
if(nomber2 > max) max = nomber2;
if(nomber3 > max) max = nomber3;

Console.WriteLine($"Наибольшее число: {max}");
