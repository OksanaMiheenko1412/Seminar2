// Задача 12 на вход 2 числа, на выход - является ли второе число кратным первому
// если число 2 некратно числу 1, программа выводит остаток от деления
// например: 34, 5 - остаток 4; 16,4 - кратно
Console.Clear();

Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое  число");
int b = Convert.ToInt32(Console.ReadLine()); 
if (a % b == 0)
    Console.Write("yes");
else
    Console.Write($"не кратно, остаток {a % b}");    