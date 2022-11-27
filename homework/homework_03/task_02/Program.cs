// Напишите программу, которая принимает на вход координаты двух точек и
//  находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координаты первой точки");

double[] firstDotArray = new double[3];
for (int i = 0; i < 3; i++)
{
firstDotArray[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine ("Введите координаты второй точки");

double[] secondDotArray = new double[3];
for (int i = 0; i < 3; i++)
{
secondDotArray[i] = double.Parse(Console.ReadLine());
}

static double Distance(double []firstDotArray, double []secondDotArray)
{
    double sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum = sum + Math.Pow((firstDotArray[i] - secondDotArray[i]), 2);
    }
    double result  = Math.Sqrt (sum);
    return  result;    
}

double distance = Distance(firstDotArray, secondDotArray);

Console.WriteLine ($"Расстояние между точками равно {distance}.");