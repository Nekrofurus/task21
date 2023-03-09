/// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Для вычисления расстояния между точками А и В, пожалуйста, введите координаты");
Console.Write("А х = ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("А y = ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("А z = ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("B х = ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("B y = ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("B z = ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());
double Distance3D (int xА, int yА, int zА, int xB,int yB, int zB)
{
    double distance3D = Math.Round(Math.Sqrt((xА-xB)*(xА-xB)+(yА-yB)*(yА-yB)+(zА-zB)*(zА-zB)) , 2);
    return distance3D;
}
double distance = Distance3D(xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
Console.WriteLine($"Расстояние от точки А до точки В = {distance}");
