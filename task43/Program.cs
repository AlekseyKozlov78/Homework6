/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. */

void CheckLines(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;

    if ((k1 == k2) && (b1 == b2))  Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)  Console.WriteLine("Прямые параллельны");
    else 
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine("Прямые пересекаются в точке с координатами: x = {0}, y = {1}", x, y);
    }

}

Console.WriteLine("Введите коэффициент k1 первой прямой");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 первой прямой");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 второй прямой");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 второй прямой");
double b2 = double.Parse(Console.ReadLine());

CheckLines(k1, b1, k2, b2);