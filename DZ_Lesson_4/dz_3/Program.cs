﻿/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console.
Только в основном блоке кода или в функции вывода*/
/*Версия 2.0 принимает не только цифры, а элементы*/
void InputArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {(i+1)} элемент из 8: ");
        arr[i] = Console.ReadLine()!;
        //Нарушил правило "Не применять Console в функции", для добавления ввода массива 
    }
}
void PrintArray(string[] arr)
{
    Console.WriteLine("PrintArray: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ");
}
void FillArray(string[] arr)
{
    Random randGenerator = new Random();
    int cache = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        cache = randGenerator.Next(0,10);
        arr[i] = $"{cache}";
    }
}
Console.Clear();
int i = 1;
string[] array = new string[8];
string menu = String.Empty;
while (i > 0)
{
    if (menu == "0")
    Console.WriteLine(" ");//Почему съедается эта строка в первом выводе?
    Console.WriteLine("1. Ввести массив");
    Console.WriteLine("2. Случайный массив");
    Console.WriteLine("Q. Выйти");
    Console.Write("Введите нужную цифру: ");
    menu = Console.ReadLine()!;
    if (menu == "1")
    {
          InputArray(array);
          PrintArray(array);
          menu = "0";
    }
    else if (menu == "2")
    {
          FillArray(array);
          PrintArray(array);
          menu = "0";
    }
    else if (menu == "q" || menu == "Q")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не верный символ, попробуйте ещё раз.");
        menu = "0";
    }
}
Console.WriteLine("До встречи!");