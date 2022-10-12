/*Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1
7 -> такого числа в массиве нет*/
double[,] CreateArray()
{
    Console.Write("Введите колличество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите колличество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = new double[m, n];
    return array;
}
void PrintArray(double[,] array)
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
void FillArray(double[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(generator.NextDouble() * 20 - 10, 1);
        }
    }
}
void ElementSearch(double[,] array)
{
    Console.Write("Введите номер строки: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите номер столбца: ");
    int n = int.Parse(Console.ReadLine()!);
    if (m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        Console.WriteLine(array[m -1 , n - 1]);
    }
    else Console.WriteLine("Такого элемента нет");
}
Console.Clear();
double[,] array = CreateArray();
FillArray(array);
PrintArray(array);
ElementSearch(array);