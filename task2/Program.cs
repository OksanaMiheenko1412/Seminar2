// task 11 программа вводит случайное 3-х значное число и на вывод показывает
// первую и третью цифру(вторую игнорирует), 456 ->46; 782 ->72; 918 ->98
Console.Clear();

int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100; // количество сотен
int n3 = n % 10; // количество единиц (последняя цифра числа)
Console.Write(n1 * 10 + n3);
