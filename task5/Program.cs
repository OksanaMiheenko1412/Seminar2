// Задача16 Программа принимает на вход 2 числа и проверяет является ли одно число
// кывдратом второго. Например: 5,25 ->да; -4,16 ->да; 8,9 -> нет.
Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое  число");
int b = Convert.ToInt32(Console.ReadLine()); 
if (a * a == b || b * b == a )
    Console.Write("yes");
else
    Console.Write("no");    
