// Задача14 программа принимает на вход число и проверяет кратно ли оно
// одновременно 7 и 23. Например: 14 ->нет, 46 ->нет, 161 ->да
Console.Clear();

Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a % 7) + (a % 23) == 0)
    Console.Write("yes");
else
    Console.Write("no");    
