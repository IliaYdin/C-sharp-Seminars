// // Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. и проверяет, является ли первое число квадратом второго.
// 3. Вывод результата.

// Например
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет

Console.Write("Введите число1: ");
int nomber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int nomber2 = Convert.ToInt32(Console.ReadLine());

if(nomber1 / nomber2 == nomber2)
{
    Console.WriteLine($"Квадрат {nomber1} является квадратом {nomber2}");
}
else
{
   Console.WriteLine($"Квадрат {nomber1} не является квадратом {nomber2}"); 
}