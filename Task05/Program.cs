// 5. Напишите программу, которая 
// 1. на вход принимает одно число (N), 
// 2. а на выходе показывает все целые числа в промежутке от -N до N.
// 3. Вывод результата.

// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");

int nomber = Convert.ToInt32(Console.ReadLine());
if (nomber>0)
{
    int count = -nomber;
    while (count <= nomber)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else
{
    Console.Write("Введено не корректное число!");
}