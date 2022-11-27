// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите первое число");
double numberOne = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе целое число, равное или больше 0, являющимся показателем степени для первого числа");
int numberTwo = int.Parse(Console.ReadLine());

double NaturalDegree(double A, int B)
{
    double[] ArrayA = new double [B];
    for (int i = 0; i < B; i++)
    {
        ArrayA[i] = A;
    }
    double degree = 1;
    for (int i = 0; i < B; i++)
    {
        degree = degree * ArrayA[i];
    }
    return degree;
}

double result = NaturalDegree(numberOne, numberTwo);
Console.WriteLine ($"Число {numberOne} в натуральной степени {numberTwo} равно {result}\n{numberOne}^{numberTwo} = {result}");