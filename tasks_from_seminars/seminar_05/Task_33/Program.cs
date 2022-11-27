// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число в массиве");
int number = int.Parse(Console.ReadLine());

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

int[] array = CreateArray(size, min, max);
PrintArray(array);
if (FindNumber(array, number))
{
    Console.WriteLine($"{number} присутствует в массиве");
}
else
{
    Console.WriteLine($"{number} отсутствует в массиве");
}

