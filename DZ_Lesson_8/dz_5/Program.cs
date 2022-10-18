/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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
    Console.WriteLine("");
}
Console.Clear();
int[,] array = new int[10, 10];
int row = 0;
int column = 0;
for(int i = 0; i <= array.Length;)
{
    while (column + 1 != array.GetLength(0) && array[row, column + 1] == 0)
    {
        i++;
        array[row, column] = i;
        column++;
    }
    while (row + 1 != array.GetLength(0) && array[row + 1, column] == 0)
    {
        i++;
        array[row, column] = i;
        row++;
    }
    while (column - 1 >= 0 && array[row, column - 1] == 0)
    {
        i++;
        array[row, column] = i;
        column--;
    }
    while ( row - 1 >= 0 && array[row - 1, column] == 0)
    {
        i++;
        array[row, column] = i;
        row--;
    }
//    if (array[row, column + 1] != 0 || array[row + 1, column] != 0 || array[row, column - 1] != 0 || array[row - 1, column] != 0)
    if(i == array.Length - 1)
    {
        i++;
        array[row, column] = i;
        break;
    }
}
PrintArray(array);