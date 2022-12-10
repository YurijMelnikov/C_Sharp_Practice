/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Введите количество колонок двумерного массива");
int RowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк двумерного массива");
int LineCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение двумерного массива");
int maxArrayValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение двумерного массива");
int minArrayValue = int.Parse(Console.ReadLine());



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

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        printColor(i + 1 + " строка" + "  ", ConsoleColor.DarkYellow);
        Console.Write(array[i]);
        Console.WriteLine();
    }
}

int[] SumLines2dArray(int[,] d2Array)
{
    int[] sumLines2dArray = new int[LineCount];
    for (int i = 0; i < d2Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < d2Array.GetLength(1); j++)
        {
            sum = sum + d2Array[i, j];
            sumLines2dArray[i] = sum;

        }
    }
    return sumLines2dArray;
}


int MinAmountOfLine(int[] array)
{
    int Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (Min > array[i])
        {
            Min = array[i];
        }
    }
    return Min;
}

int MinIndex(int[] array, int Min)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Min)
        {
            minIndex = i;
            return minIndex;
        }
    }
    return minIndex;
}





int[,] d2Array = ArrayGeneretion(LineCount, RowCount, minArrayValue, maxArrayValue);
Console.WriteLine("Вывод сгенерированного массива");
print2dArray(d2Array);
int[] sumLines2dArray = SumLines2dArray(d2Array);
Console.WriteLine("\nВывод сумм каждой строки сгенерированного двумерного массива");
printArray(sumLines2dArray);
int Min = MinAmountOfLine(sumLines2dArray);
int minIndex = MinIndex(sumLines2dArray, Min);
Console.WriteLine($"Строка {minIndex + 1} с наименьшей суммой");