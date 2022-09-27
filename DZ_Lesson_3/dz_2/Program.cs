// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты X для A: ");
double xA = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y для A: ");
double yA = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Z для A: ");
double zA = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты X для B: ");
double xB = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y для B: ");
double yB = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Z для B: ");
double zB = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние между точек = {distance:f2}");
