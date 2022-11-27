// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// 

int size = 123;
int min = -100;
int max = 200;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 1;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));