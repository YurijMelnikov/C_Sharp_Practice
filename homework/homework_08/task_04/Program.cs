/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void NonRepeatingValues(int i, int[] array)
/*Рекурсивный метод по заполнению одномерного массива не повторяющимися случайными двузначными числами,
 к сожалению не работает при приближении к максимально возможной длине массива*/
{
    if (i != array.Length)
    {
        array[i] = new Random().Next(-99, 98 + 1);
        if (array[i] > -10 && array[i] < 10)
        {
            NonRepeatingValues(i, array);
        }
        else
        {
            for (int k = 0; k < i; k++)
            {
                if (array[i] == array[k])
                {
                    NonRepeatingValues(i, array);
                }
            }
            NonRepeatingValues(i + 1, array);
        }
    }
    else
    {
        return;
    }
}

int[,,] Array3D(int firstDimensionCount3DArray, int secondDimensionCount3DArray, int thirdDimensionCount3DArray, int[] array) 
/* Создание на основе введённых данных и заполнение
трёхмерного массива не повторяющимися значениями одномерного массива. 
Долго думал, как связать индексы трёхмерного массива с индексом одномерного, 
очень долго думал и экспериментировал с выражениями, долго смеялся над собой, когда дошло прикрутить счётчик циклов. */
{
    int[,,] array3D = new int[firstDimensionCount3DArray, secondDimensionCount3DArray, thirdDimensionCount3DArray];
    int countCycle = 0; //счётчик циклов, для привязки его к индексу одномерного массива
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int m = 0; m < array3D.GetLength(2); m++)
            {
                array3D[i, j, m] = array[countCycle];
                countCycle++;
            }
        }
    }
    return array3D;
}

void PrintArray(int[] arbitraryArray)
{
    Console.Write("[");
    for (int i = 0; i < arbitraryArray.Length; i++)
        if (i != arbitraryArray.Length - 1)
        {
            {
                printColor($"{arbitraryArray[i]}, ", ConsoleColor.Green);
            }
        }
        else
        {
            printColor($"{arbitraryArray[i]}", ConsoleColor.Green);
            Console.Write("]");
            Console.WriteLine();
        }
}

void print3DArrayValues(int[,,] Arbitary3DArray)
{
    printColor("Элемент   Индекс", ConsoleColor.DarkYellow);
    Console.WriteLine();
    for (int i = 0; i < Arbitary3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < Arbitary3DArray.GetLength(1); j++)
        {
            for (int m = 0; m < Arbitary3DArray.GetLength(2); m++)
            {
                printColor($"{Arbitary3DArray[i, j, m]} ", ConsoleColor.Red);
                printColor($"\t({i}, {j}, {m})", ConsoleColor.Green);
                Console.WriteLine();
            }
        }
    }
}

void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

Console.WriteLine("Введите длину первого измерения трёхмерного массива");
int firstDimensionCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину второго измерения трёхмерного массива");
int secondDimensionCount = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину третьего измерения трёхмерного массива");
int thirdDimensionCount = int.Parse(Console.ReadLine());

int[] array = new int[firstDimensionCount * secondDimensionCount * thirdDimensionCount]; // Создание одномерного массива, с таким же количеством элементов, как и у трёхмерного, для заполнения его не повторяющимися двухзначными числами.

Console.WriteLine("Создание и вывод одномерного массива, заполненного неодинаковыми двузначными цифрами,\nc количеством элементов равным, количеству элементов трёхмерного массива");
Console.WriteLine();
NonRepeatingValues(0, array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Заполнение трёхмерного массива по порядку значениями из одномерного массива и вывод каждого элемента трёхмерного массива с его индексами");
int[,,] array3D = Array3D(firstDimensionCount, secondDimensionCount, thirdDimensionCount, array);
Console.WriteLine();
print3DArrayValues(array3D);