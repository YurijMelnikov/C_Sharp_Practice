/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.WriteLine("Введите количество элементов в массиве");
int count = int.Parse(Console.ReadLine());
if (count == 1)
{
    Console.WriteLine($"В массиве из одного элемента нет чётных индексов");
    return;
}
Console.WriteLine("Введите максимальное значение в массиве (целые числа)");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве (целые числа)");
int minValue = int.Parse(Console.ReadLine());

int[] arrayGeneration(int Length, int minValue, int maxValue)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
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
int SumOddIndex(int[] arbitraryArray)
{
    int sum = 0;
    for (int i = 1; i < arbitraryArray.Length; i += 2)
    {
        sum = sum + arbitraryArray[i];
    }
    return sum;
}
int[] array = arrayGeneration(count, minValue, maxValue);
PrintArray(array);
int sum = SumOddIndex(array);
Console.WriteLine($"Сумма элементов массива с нечётными индексами равна {sum}");