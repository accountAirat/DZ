/*
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
1 строка (нумерация строк начинается с 1)
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine("");
    }

}
void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(1, 10);
        }
    }
}
Console.Clear();
int[,] array = new int[4,3];
FillArray(array);
PrintArray(array);
int index = 0;
int sum = 0;
int sumNew = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumNew += array[i, j];
    }
    if (i == 0)
        sum = sumNew;
    else if (sumNew < sum) 
    {
        sum = sumNew;
        index = i;
    }
    sumNew = 0;
}
Console.WriteLine("");
Console.WriteLine(index + 1);