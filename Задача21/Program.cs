// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек");
Console.Write("Введите x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Z = Math.Pow(x1-x2, 3) + Math.Pow(y1-y2, 3);
Console.WriteLine("Расстояние между точками равно:"+ Z);