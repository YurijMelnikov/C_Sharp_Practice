// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число в массиве");
int number = int.Parse(Console.ReadLine());

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



int MultArray(array)
{
    int i = 0;
    int u = size - 1;
    while (i <= (size-1)/2)
    int [] = newArray[(size-1)/2];
    int newArray[] = array[i]*array[u];
    Console.Write ($"{mult} ");
    i++;
    u = size - i;
}
MultArray(array);