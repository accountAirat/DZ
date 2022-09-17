/*Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.*/

Console.Clear();

Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);
Console.Write("Введите третье число: ");
string inputC = Console.ReadLine();
int numberC = int.Parse(inputC);

int max = numberA;

if (max < numberB)
    max = numberB;
if (max < numberC)
    max = numberC;

Console.Write($"max={max}.");