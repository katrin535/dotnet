/*## Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7

44, 5, 78 -> 78

22, 3, 9 -> 22*/

Console.Write("Введите число a: ");
string N = Console.ReadLine();
int a = Convert.ToInt32(N);

Console.Write("Введите число b: ");
string K = Console.ReadLine();
int b = Convert.ToInt32(K);

Console.Write("Введите число c: ");
string L = Console.ReadLine();
int c = Convert.ToInt32(L);

int max = a;

if (b > max) max = b;
if (c > max) max = c;
Console.Write ("max = ");
Console.WriteLine(max);