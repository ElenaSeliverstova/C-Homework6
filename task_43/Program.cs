// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// example: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindCoord(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] coord = new double[2];
    coord[0] = x;
    coord[1] = y;
    return coord;
}
Console.Write("Введите значения b1, k1, b2, k2 через пробел: ");
string[] array = Console.ReadLine().Split(" ");
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);
double[] result = FindCoord(b1, k1, b2, k2);
Console.Write($"Координаты точки ({result[0]}, {result[1]})");