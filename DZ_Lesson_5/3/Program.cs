/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

void FillDoubleArray(double[] arr)
{
    Random generator = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = generator.NextDouble();
    }
}
double CheckArrayMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
     if (max < arr[i])
     {
        max = arr[i];
     }   
     else if (min > arr [i])
     {
        min = arr [i];
     }
    }

    double result = max - min;
    return result;
}
double[] array = new double[10];
FillDoubleArray(array);
Console.Write($"{String.Join(", ", array)} -> {CheckArrayMaxMin(array)}");