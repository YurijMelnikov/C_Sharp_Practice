/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] SpiralArrayFilling(int D2ArrayLineCount, int D2ArrayRowCount)
{
    int[,] d2Array = new int[D2ArrayLineCount, D2ArrayRowCount];
    int F = 1; // Начальное значение массива, которое будет увеличиваться на единицу в каждой итерации спирального заполнения массива 
    int i; // Инициализация переменных для индекса массива
    int j; // Инициализация переменных для индекса массива

    //Четыре цикла для заполнения периметра двумерного массива
    for (j = 0; j < D2ArrayRowCount; j++)  //Заполняем верхнюю строчку массива слева направо
    {
        d2Array[0, j] = F;
        F++;
    }
    for (i = 1; i < D2ArrayLineCount; i++) //Заполняем правую строчку массива сверху вниз
    {
        d2Array[i, D2ArrayRowCount - 1] = F;
        F++;
    }
    for (j = D2ArrayRowCount - 2; j >= 0; j--) //Заполняем нижнюю строчку массива справа налево
    {
        d2Array[D2ArrayLineCount - 1, j] = F;
        F++;
    }
    for (i = D2ArrayLineCount - 2; i > 0; i--) //Заполняем левую строчку массива снизу вверх
    {
        d2Array[i, 0] = F;
        F++;
    } //Периметр заполнен

    i = 1; 
    j = 1;  //Переходим к первому не заполненному элементу массива, внутри периметра

    while (F < D2ArrayLineCount * D2ArrayRowCount) //основной цикл заполнения значений вне периметра
    {
        while (d2Array[i, j + 1] == 0) //первый цикл, заполняет верхнюю линию, внутри периметра и меньше, слева направо, условие выхода проверяет заполнена ли следующая ячейка массива нулём, если нет, значит мы вызвали значение из периметра (или заполненного до этого прямоугольника) и цикл прервётся
        {
            d2Array[i, j] = F;
            F++;
            j++;
        }
        while (d2Array[i + 1, j] == 0) //второй цикл, заполняет правую линию, внутри периметра и меньше, сверху вниз, условие выхода аналогично первому циклу
        {
            d2Array[i, j] = F;
            F++;
            i++;
        }
        while (d2Array[i, j - 1] == 0) //третий цикл, заполняет нижнюю линию, внутри периметра и меньше, справа налево, условие выхода аналогично первому циклу
        {
            d2Array[i, j] = F;
            F++;
            j--;
        }
        while (d2Array[i - 1, j] == 0) //четвёртый цикл, заполняет левую линию, внутри периметра и меньше, снизу вверх, условие выхода аналогично первому циклу
        {
            d2Array[i, j] = F;
            F++;
            i--;
        }
    //после выполнения всех циклов, значение i = 2 и j = 1, следовательно мы перешли к следующему прямоугольнику для заполнения и так далее, пока не дойдём до центра. Переход осуществляется перезаписью одним и тем же значением последнего элемента в прямоугольнике, для первого прямоугольника (i = 2, j = 1) итд  
    }
    for (i = 0; i < D2ArrayLineCount; i++) // При данном заполнении массива остаётся последний, не заполненный элемент в центре, значение которого по умолчанию равно нулю, находим его циклом и заполняем - задача выполнена, ура!
    {
        for (j = 0; j < D2ArrayRowCount; j++)
        {
            if (d2Array[i, j] == 0)
            {
                d2Array[i, j] = F;
            }
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





printColor("Спиральное заполнение квадратного массива по возрастанию от единицы, по часовой стрелке\n", ConsoleColor.Green);
Console.WriteLine("Введите длину квадратного массива (число строк и колонок равно)");
int lineCount = int.Parse(Console.ReadLine());
int rowCount = lineCount;
int [,] d2Array = SpiralArrayFilling(lineCount, rowCount);
print2dArray(d2Array);