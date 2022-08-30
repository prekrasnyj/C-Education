//Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.
// ----->
// |A1A2| = sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)

//метод считает расстояние между двумя точками в 3Д пространстве
//по координатам XYZ
double FindDistanceTwoPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Abs(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));
    return result;
}

Console.Write("Введите координату Х первой точки - ");
double xFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки - ");
double yFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки - ");
double zFirst = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х второй точки - ");
double xSecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки - ");
double ySecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки - ");
double zSecond = Convert.ToDouble(Console.ReadLine());

double distance = FindDistanceTwoPoints(xFirst, yFirst, zFirst, xSecond, ySecond, zSecond);
Console.Write("Расстояние между точками - ");
Console.WriteLine(Math.Round(distance,2));