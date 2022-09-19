/* Напишите программу, которая на вход принимает число и 
выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Clear();

Console.Write("Введите число: ");
string num = Console.ReadLine();
int number = int.Parse(num);

if (number % 2 == 0)
{
    Console.Write("Число чётное.");
}
else
{
    Console.Write("Число нечётное.");
}
