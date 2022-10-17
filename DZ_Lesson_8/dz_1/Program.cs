/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateArray()
{
    Console.Write("Введите колличество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колличество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];
    return array;
}
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j ] = array[i, k];
                    array[i, k ] = temp;
                }
            }
        }
    }
}
Console.Clear();
int[,] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine("");
SortArray(array);
PrintArray(array);