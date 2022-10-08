Console.Write("Введите день недели цифрой от 1 до 7, где 1 - пон, 7 - воскр: ");
string str = Console.ReadLine();
if (str == "6" || str =="7")
{
    Console.WriteLine ("Да");
}
else if (str == "1" || str =="2" || str == "3" || str =="4" || str =="5")
{
     Console.WriteLine ("Нет");
}
else Console.WriteLine ("Что-то не то");