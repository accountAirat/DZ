/*Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвращает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console.
Только в основном блоке кода*/
Console.Clear();
int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Cумму цифр в числе = {Sum(number)}");