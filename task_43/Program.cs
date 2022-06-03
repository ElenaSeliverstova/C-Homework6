// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// example: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значения b1, k1, b2, k2 через пробел: ");
double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
Console.WriteLine(String.Join(" ", array));
double b1 = array[0];
double k1 = array[1];
double b2 = array[2];
double k2 = array[3];
double x = (b2 - b1) / (k1 - k2);
Console.Write($"Координаты точки пересечения ({x} , {k1 * x + b1})");

