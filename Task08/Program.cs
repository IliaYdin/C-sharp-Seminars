// 8. Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int nomber = Convert.ToInt32(Console.ReadLine());
int count = 0;

    while(count < nomber)
    {
         count ++;
         if (count % 2 == 0)
        Console.Write($"{count} ");
    }



