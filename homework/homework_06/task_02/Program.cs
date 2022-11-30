// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения k1 и b1 прямой заданной функцией: y = k1 * x + b1");
Console.Write ("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write ("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значения k2 и b2 прямой заданной функцией: y = k2 * x + b2");
Console.Write ("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write ("b2 = ");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}
Console.WriteLine ($"Координаты точки пересечения прямых: y = {k1}*x + {b1} и y = {k2}*x + {b2}\n({x}; {y})");