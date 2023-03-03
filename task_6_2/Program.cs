/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)           */

Console.Clear();

double EnterCoord(string message)
{
    Console.Write(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}

Console.WriteLine("Введите два значения первого уравнения");
double b1 = EnterCoord("b1: ");
double k1 = EnterCoord("k1: ");

Console.WriteLine("Введите два значения второго уравнения ");
double b2 = EnterCoord("b2: ");
double k2 = EnterCoord("k2: ");

double x = (b2 - b1) / (k1 - k2);

double y = k1 * x + b1;

Console.WriteLine($"Координата пересечения прямых, заданных уравнениями: Х={x}, Y={y}");