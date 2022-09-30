/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
void ArrayFill(int[] arr)
{
    Random generator = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = generator.Next(100, 1000);
    }
}
int CheckArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
}
int[] array = new int[10];
ArrayFill(array);
Console.Write($"{String.Join(", ", array)} -> {CheckArray(array)}");