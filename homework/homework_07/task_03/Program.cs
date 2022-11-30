/*Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите число столбцов в двумерном массиве");
int lengthCol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк в двумерном массиве");
int lengthRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное, значение в массиве");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
int minValue = int.Parse(Console.ReadLine());

int[,] TwoDimensionalArrayGeneration(int lengthCol, int lengthRow, int minValue, int maxValue)
{
    int[,] twoDimensionalArray = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            twoDimensionalArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return twoDimensionalArray;
}

void print2dArray(int[,] array) 
{
    Console.WriteLine ("Вывод сгенерированного массива"); 
    Console.Write("\t"); 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        printColor(i + "\t",ConsoleColor.DarkYellow); 
    } 
    Console.WriteLine(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        printColor(i+"\t",ConsoleColor.DarkYellow); 
        for (int j = 0; j <  array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + "\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

void printColor(string information, ConsoleColor color) 
{ 
    Console.ForegroundColor = color; 
    Console.Write(information); 
    Console.ResetColor(); 
}


double [] ArithmeticMeanInEveryColumn2DArray (int [,] array)
{
double [] arithmeticMeanArray = new double[array.GetLength(1)];
for (int j = 0; j <  array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            sum = sum + array[i , j];
        }
        arithmeticMeanArray [j] = (double) sum / array.GetLength(0);
    }
    return arithmeticMeanArray;
}


void PrintArray(double[] arbitraryArray)
{
    Console.WriteLine("Среднее арифметическое каждого столбца");
    Console.Write("[");
    for (int i = 0; i < arbitraryArray.Length; i++)
        if (i != arbitraryArray.Length - 1)
        {
            {
                Console.Write($"{arbitraryArray[i]}, ");

            }
        }
        else
        {
            Console.Write($"{arbitraryArray[i]}]\n");
        }
}
int [,] twoDimensionalArray = TwoDimensionalArrayGeneration(lengthCol, lengthRow, minValue, maxValue);
print2dArray(twoDimensionalArray);
double [] arithmeticMeanArray = ArithmeticMeanInEveryColumn2DArray(twoDimensionalArray);
PrintArray(arithmeticMeanArray);
