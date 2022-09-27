// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 9999 && number < 100000)
    if ((number / 10000 == number % 10) && (number % 10000 / 1000 == number % 100 / 10))
        Console.WriteLine("Число палиндром");
    else 
        Console.WriteLine("Число не палиндром");
else
    Console.Write("Число не пятизначное!");