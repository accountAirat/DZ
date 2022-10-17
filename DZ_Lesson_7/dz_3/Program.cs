/*Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
            array[i, j] = Math.Round(generator.NextDouble() * 9, 0);
        }
    }
}
void AverageСolumn(double[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write(Math.Round(sum / array.GetLength(1), 1) + "; ");
    }
}
Console.Clear();
double[,] array = CreateArray();
FillArray(array);
PrintArray(array);
AverageСolumn(array);