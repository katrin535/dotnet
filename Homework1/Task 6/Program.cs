﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
string b = Console.ReadLine();
int a = Convert.ToInt32(b);

if (a % 2 == 0) 
{
    Console.Write(a);
    Console.WriteLine(" - четное");
}
else
{
    Console.Write(a);
    Console.WriteLine(" - нечетное");
}