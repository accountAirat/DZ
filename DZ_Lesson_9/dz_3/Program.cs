/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int Acerman2(int n, int m)
{
    if (n == 0)
        return ++m;
    else if (m == 0)
        return Acerman2(--n, 1);
    else
        return Acerman2(n - 1, Acerman2(n, m - 1));
}
Console.Clear();
int numberOne = int.Parse(Console.ReadLine()!);
int numberTwo = int.Parse(Console.ReadLine()!);
Console.WriteLine(Acerman2(numberOne, numberTwo));