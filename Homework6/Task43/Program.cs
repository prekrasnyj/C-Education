// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

//Метод проверяет пересекаются ли прямые
void SearchIntersectionPoints(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 & b1 == b2) { Console.WriteLine("Прямые совпадают"); }
    else if (k1 == k2) { Console.WriteLine("Прямые параллельны"); }
    else
    {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 *x + b1;
        x = Math.Round(x, 1);
        y = Math.Round(y, 1);
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})"); 
    }

}


Console.Write("Введите b1 - ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1 - ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 - ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 - ");
double k2 = Convert.ToDouble(Console.ReadLine());

SearchIntersectionPoints(b1, k1, b2, k2);