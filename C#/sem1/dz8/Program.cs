﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;

if (N % 2 == 0)
{
    while (a < N + 1)
  {
    Console.Write ($"{a} ");
    a = a + 2;
  }
}
else
{
    while (a < N)
  {
    Console.Write ($"{a} ");
    a = a + 2;
  }
}