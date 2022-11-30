/* Напишите программу, которая на вход принимает позиции
 элемента в двумерном массиве, и возвращает значение этого элемент
 а или же указание, что такого элемента нет.
Например, задан массив:
    [0][1][2][3]
[0]  1  4  7  2
[1]  5  9  2  3
[2]  8  4  2  4

17 -> такого числа в массиве нет

[0][1][2][3][4][5][6][7][8][9][10][11]
 1  4  7  2  5  9  2  3  8  4   2  4
9 -> 4
5 -> 9 */

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
    Console.WriteLine();
}


double[,] twoDimensionalArray = TwoDimensionalArrayGeneration(lengthCol, lengthRow, minValue, maxValue);
print2dArray(twoDimensionalArray);
Console.WriteLine("Введите номер колонки в двумерном массиве");
int сol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер строки в двумерном массиве");
int row = int.Parse(Console.ReadLine());

if (сol > lengthCol || row > lengthRow)
{
    Console.WriteLine("В массиве нет значений с таким индексом");
}
else
{
    double result = twoDimensionalArray[(row - 1), (сol - 1)];
    Console.WriteLine($"Значение элемента массива с номером колонки {сol} и номером строки {row}, то есть с индексом [{row - 1}, {сol - 1}] равно {result}");
}