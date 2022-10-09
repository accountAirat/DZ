// Задача 41: Пользователь вводит с клавиатуры число M,
// потом вводит M чисел ЧЕРЕЗ ENTER. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 5
// 0
// 7
// 8
// -2
// -2 -> 2

// 5
// 1
// -7
// 567
// 89
// 223-> 3

int[] CreateArray()
{
    Console.Write("Введите раpмер массива: ");
    int[] arr = new int[int.Parse(Console.ReadLine()!)];
    return arr;
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int CheckArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}
Console.Clear();
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine($"Чисел больше 0 : {CheckArray(array)}");
