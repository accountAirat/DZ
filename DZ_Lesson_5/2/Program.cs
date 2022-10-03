/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

void ArrayFill(int[] arr)
{
    Random generator = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = generator.Next(-100, 100);
    }
}
int CheckArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }
    return sum;
}
int[] array = new int[10];
ArrayFill(array);
Console.Write($"{String.Join(", ", array)} -> {CheckArray(array)}");