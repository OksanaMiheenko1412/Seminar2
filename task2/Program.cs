﻿// task 11
Console.Clear();

int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100; // количество сотен
int n3 = n % 10; // количество единиц (последняя цифра числа)
Console.Write(n1 * 10 + n3);
