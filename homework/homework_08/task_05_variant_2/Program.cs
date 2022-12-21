/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


int[,] SpiralArrayFilling(int lineCount, int rowCount, int startValue)
{
    /*Для спирального заполнения массива будем заполнять поочерёдно каждый прямоугольник из элементов двигаясь к центру массива
    Введём четыре дополнительных переменных для обозначения этого прямоугольника */

    int Up = 0; //Верхняя граница прямоугольника
    int Right = 0; //Правая граница прямоугольника
    int Left = 0; //Левая граница прямоугольника 
    int Down = 0; //Нижняя граница прямоугольника

    int i = 0; //инициализация первого индекса двумерного массива 
    int j = 0; //инициализация второго индекса двумерного массива
    int counter = 0; // Счётчик цикла
    int[,] d2Array = new int[lineCount, rowCount]; //Инициализация пустого массива, который будет спирально заполняться
    while (counter <= lineCount * rowCount) //Цикл заполнения массива, переменная counter - счётчик цикла.
    {
        d2Array[i, j] = startValue;
        if (i == Up && j < rowCount - Down - 1) //Заполнение верхней строчки массива, заполняем слева направо. Когда условие перестаёт выполняться, идёт переход к следующей стороне условного прямоугольника
        {
            j++;
        }
        else
        {
            if (j == rowCount - Down - 1 && i < lineCount - Right - 1) //Заполнение правой строчки массива, сверху вниз.
            {
                i++;
            }
            else
            {
                if (i == lineCount - Right - 1 && j > Left) //Заполнение нижней строчки массива справа налево.
                {
                    j--;
                }
                else //Заполнение левой строчки массива снизу вверх
                {
                    i--;
                }
            }
        }
        if ((i == Up + 1) && (j == Left) && (Left != rowCount - Down - 1)) //Условие, при котором заполнен первый прямоугольник и идёт переход ко второму. Дополнительные переменные увеличиваются на единицу. Третий операнд в условии нужен для конечного заполнения массива, когда заполняется не прямоугольник, а линия.
        {
            Up++;
            Right++;
            Left++;
            Down++;
        }
        startValue++;
        counter++;  //увеличиваем счётчик цикла на единицу, необходимо для условия выхода из цикла
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


printColor("Спиральное заполнение произвольного массива по возрастанию на единицу, от произвольного заданного целого значения, по часовой стрелке\n", ConsoleColor.Green);
Console.WriteLine("\nВведите количество строк двумерного массива");
int lineCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество колонок двумерного массива");
int rowCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение, с которого начнётся спиральное заполнение двумерного массива");
int startValue = int.Parse(Console.ReadLine());
int [,] d2Array = SpiralArrayFilling (lineCount, rowCount, startValue);
printColor("Вывод спирально заполненного массива\n", ConsoleColor.Green);
print2dArray(d2Array);