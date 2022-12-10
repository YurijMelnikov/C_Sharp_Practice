/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в
 промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите целое положительное число");
int N = int.Parse(Console.ReadLine());
if (N < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

int[] array = new int[N];
int i = 0;
int[] ArrayGeneration(int number)
{
    if (number >= 1)
    {
        array[i] = number;
        i++;
        ArrayGeneration(number - 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + "," + " ");
        }

    }
    Console.Write(array[array.Length - 1] + "]");
}


int[] arrayNaturalNumbers = ArrayGeneration(N);
Console.WriteLine($"Вывод всех натуральных чисел от {N} до 1");
PrintArray(arrayNaturalNumbers);