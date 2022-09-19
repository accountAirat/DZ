/* Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
int i = 1;


Console.Write("Введите число: ");
string num = Console.ReadLine();
int number = int.Parse(num);

while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
        i++;
    }
    else
    {
        i++;
    }

}