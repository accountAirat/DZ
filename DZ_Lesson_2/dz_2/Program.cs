/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

/* В задании не точно написаннно, принимать на вход чило или генерировать его.
Я сделал принимать*/
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 100){
     while (number > 1000){
        number = number / 10;
    }
    Console.Write("Третья цифра: "+(number%10));
}
else if (number < -100){
     while (number < -1000){
        number = number / 10;
    }
    Console.Write("Третья цифра: "+(number%10));
}
else {
    Console.Write("Третьей цифры нет");
}