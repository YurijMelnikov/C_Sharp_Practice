/*Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
    [0][1][2] [3]
[0]  0,5 7 -2 -0,2
[1]  1 -3,3 8 -9,9
[2]  8 7,8 -7,1  9 */

Console.WriteLine("Введите число столбцов в двумерном массиве");
int lengthCol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк в двумерном массиве");
int lengthRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное, значение в массиве");
double maxValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
double minValue = double.Parse(Console.ReadLine());

double[,] TwoDimensionalArrayGeneration(int lengthCol, int lengthRow, double minValue, double maxValue)
{
    double[,] twoDimensionalArray = new double[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Random random = new Random();
            twoDimensionalArray[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return twoDimensionalArray;
}

void print2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.WriteLine();
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }        
    
    }
}

void printColor(string information, ConsoleColor color) 
{ 
    Console.ForegroundColor = color; 
    Console.Write(information); 
    Console.ResetColor(); 
}

double[,] TwoDimensionalArray = TwoDimensionalArrayGeneration(lengthCol, lengthRow, minValue, maxValue);
print2dArray(TwoDimensionalArray);
