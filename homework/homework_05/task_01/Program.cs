//  Задайте массив заполненный случайными положительными трёхзначными числами.
//   Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов в массиве");
int count = int.Parse(Console.ReadLine());

int[] arrayGeneration(int Length)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int evenCount(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }

    }
    return quantity;
}

void PrintArray(int[] arbitraryArray)
{
    Console.WriteLine("Вывод сгенерированного массива");
    Console.Write("[");



    for (int i = 0; i < arbitraryArray.Length; i++)
        if (i != arbitraryArray.Length - 1)
        {
            {
                Console.Write($"{arbitraryArray[i]}, ");

            }
        }
        else
        {
            Console.Write($"{arbitraryArray[i]}]\n");
        }
}

int[] array = arrayGeneration(count);
PrintArray(array);
int quantity = evenCount(array);


Console.WriteLine($"Количество чётных элементов в массиве равно {quantity}");