// 3. Напишите программу, которая 
// 1. будет выдавать название дня недели по заданному номеру.
// 2. Вывод результата.

// Например:
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
int nomber = Convert.ToInt32(Console.ReadLine());

if(nomber == 3)
{
    Console.WriteLine("Среда");
}
else if (nomber == 5)
{
   Console.WriteLine("Пятница");;
}
else
{
   Console.WriteLine("Неустановленный день недели");
}