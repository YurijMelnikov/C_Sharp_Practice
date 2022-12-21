/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/



int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    int[,] MatrixMult = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
    for (int i = 0; i < MatrixMult.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixMult.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < Matrix1.GetLength(1); r++)
            {
                sum = sum + Matrix1[i, r] * Matrix2[r, j];
                MatrixMult[i, j] = sum;
            }

        }
    }
    return MatrixMult;
}


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

Console.WriteLine("Введите количество колонок первой матрицы");
int RowCountMatrix1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк первой матрицы");
int LineCountMatrix1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента первой матрицы");
int maxArrayValueMatrix1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента первой матрицы");
int minArrayValueMatrix1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество колонок второй матрицы");
int RowCountMatrix2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы");
int LineCountMatrix2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента второй матрицы");
int maxArrayValueMatrix2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента второй матрицы");
int minArrayValueMatrix2 = int.Parse(Console.ReadLine());

if (RowCountMatrix1 != LineCountMatrix2)
{
    Console.Write("Умножение матриц, ");
    printColor("невозможно", ConsoleColor.Red);
    Console.Write(", матрицы не согласованы, число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
    return;
}

int[,] Matrix1 = ArrayGeneretion(LineCountMatrix1, RowCountMatrix1, minArrayValueMatrix1, maxArrayValueMatrix1);
printColor("\nВывод первой матрицы\n", ConsoleColor.Green);
print2dArray(Matrix1);
int[,] Matrix2 = ArrayGeneretion(LineCountMatrix2, RowCountMatrix2, minArrayValueMatrix2, maxArrayValueMatrix2);
printColor("\nВывод второй матрицы\n", ConsoleColor.Green);
print2dArray(Matrix2);
int[,] MatrixMult = MatrixMultiplication(Matrix1, Matrix2);
printColor("\nВывод произведения матриц\n", ConsoleColor.Green);
print2dArray(MatrixMult);