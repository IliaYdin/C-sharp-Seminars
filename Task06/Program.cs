// 6. Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 3. Вывод результата.

Console.Write("Введите число: ");
int nomber = Convert.ToInt32(Console.ReadLine());

if(nomber % 2 == 0)
{
    Console.Write($"Число {nomber} четное");
}
else 
{
    Console.Write($"Число {nomber} нечетное");
}