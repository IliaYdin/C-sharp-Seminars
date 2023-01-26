// 2. Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. и выдаёт, какое число большее, а какое меньшее.
// 3. Вывод результата.

// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число1: ");
int nomber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int nomber2 = Convert.ToInt32(Console.ReadLine());

if(nomber1 > nomber2)
{
    Console.WriteLine($"max == {nomber1}");
}
else
{
   Console.WriteLine($"max == {nomber2}"); 
}