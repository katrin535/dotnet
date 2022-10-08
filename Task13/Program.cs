


Console.Write("Введите число: ");
string str = Console.ReadLine();
int a = Math.Abs(Convert.ToInt32(str));
string c = Convert.ToString(a);
if (c.Length > 2)
{
    Console.WriteLine("третья цифра числа: " + c[2]);
}
else 
{
    Console.WriteLine("третья цифра числа: отсутствует");
}

