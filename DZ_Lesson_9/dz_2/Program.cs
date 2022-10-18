/*
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int NaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber < secondNumber)
    {
        return firstNumber + NaturalNumbers(++firstNumber, secondNumber);
    }
    else
    {
        return firstNumber;
    }
}


Console.Clear();
int numberOne = int.Parse(Console.ReadLine()!);
int numberTwo = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturalNumbers(numberOne, numberTwo));