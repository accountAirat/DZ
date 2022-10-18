/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
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
void ProductTwoArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {

        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] * array2[i, j] + " | ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
Console.Clear();
int[,] arrayOne = new int[4, 3];
int[,] arrayTwo = new int[4, 3];
FillArray(arrayOne);
PrintArray(arrayOne);
FillArray(arrayTwo);
PrintArray(arrayTwo);
ProductTwoArray(arrayOne, arrayTwo);