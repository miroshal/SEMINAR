﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);