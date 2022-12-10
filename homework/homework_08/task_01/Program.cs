/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
 строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] ArrayGeneretion(int numberOfLines, int numberOfColumns, int minArrayValue, int maxArrayValue)
{
    int[,] d2Array = new int[numberOfLines, numberOfColumns];
    for (int i = 0; i < numberOfLines; i++)
    {
        for (int j = 0; j < numberOfColumns; j++)
        {
            d2Array[i, j] = new Random().Next(minArrayValue, maxArrayValue + 1);
        }
    }
    return d2Array;
}

void print2dArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
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

int[,] ArraySort(int[,] d2Array)
{
    int[,] d2SortedArray = d2Array;
    for (int i = 0; i < d2SortedArray.GetLength(0); i++)
    {
        for (int j = 0; j < d2SortedArray.GetLength(1); j++)
        {

            for (int k = j + 1; k < d2SortedArray.GetLength(1); k++)
            {
                if (d2SortedArray[i, j] < d2SortedArray[i, k])
                {
                    int buff = d2SortedArray[i, j];
                    d2SortedArray[i, j] = d2SortedArray[i, k];
                    d2SortedArray[i, k] = buff;
                }
            }
        }
    }
    return d2SortedArray;
}

Console.WriteLine("Введите количество колонок двумерного массива");
int RowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк двумерного массива");
int LineCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение двумерного массива");
int maxArrayValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение двумерного массива");
int minArrayValue = int.Parse(Console.ReadLine());


int[,] d2Array = ArrayGeneretion(LineCount, RowCount, minArrayValue, maxArrayValue);
Console.WriteLine("Вывод сгенерированного массива");
print2dArray(d2Array);
int[,] d2SortedArray = ArraySort(d2Array);
Console.WriteLine("Вывод отсортированного массива");
print2dArray(d2SortedArray);