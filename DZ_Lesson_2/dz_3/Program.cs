/* Напишите программу, которая принимает на вход цифру,обозначающую
день недели, и проверяет, является ли этот день выходным. */
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7){
    Console.Write("Этот день выходной");
}
else if (number > 0 && number < 6){
    Console.Write("Это будний день недели");
}
else if (number == 0 || (number > 7 && number < 10))
    Console.Write("Дня недели под такой цифрой нет");
else 
    Console.Write ("Это не цифра, а цифры!");