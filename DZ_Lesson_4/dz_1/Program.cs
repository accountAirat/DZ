﻿/*Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console.
Только в основном блоке кода*/
Console.Clear();
int Power(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 1; i < numberB; i++)
        {
            result *= numberA;
        }
return result;
}
Console.Write ("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberA} в степень {numberB} = {Power(numberA, numberB)}");