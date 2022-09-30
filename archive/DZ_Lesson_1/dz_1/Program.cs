/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9*/

Console.Clear();

int max = 0;
int min = 0;

Console.Write("Введите первое число ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);
Console.Write("Введите второе число ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

if(numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}

Console.Write($"max={max}, min={min}.");