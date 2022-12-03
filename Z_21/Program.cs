// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты x точки А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки А");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки А");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние в 3D пространстве = {dist} ");
