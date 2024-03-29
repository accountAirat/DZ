﻿/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void NaturalNumbers(int number)
{
    if ( number == 0)
        return;
    else 
    {
        Console.Write(number + " ");
        NaturalNumbers(--number);
    }
}

Console.Clear();
int num = int.Parse(Console.ReadLine()!);
NaturalNumbers(num);