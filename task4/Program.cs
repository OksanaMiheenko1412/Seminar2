Console.Clear();

Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a % 7) + (a % 23) == 0)
    Console.Write("yes");
else
    Console.Write("no");    
