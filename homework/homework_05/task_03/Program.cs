// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите количество элементов в массиве");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное, значение в массиве");
double maxValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
double minValue = double.Parse(Console.ReadLine());


double[] arrayGeneration(int Length, double minValue, double maxValue)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        Random random = new Random();
        array[i] = random.NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}
void PrintArray(double[] arbitraryArray)
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

double MaximumArrayNumber(double[] arbitraryArray)
{
    double max = arbitraryArray[0];
    for (int i = 0; i < arbitraryArray.Length; i++)
    {
        if (max < arbitraryArray[i])
        {
            max = arbitraryArray[i];
        }
    }
    return max;
}

double MinimumArrayNumber(double[] arbitraryArray)
{
    double min = arbitraryArray[0];
    for (int i = 0; i < arbitraryArray.Length; i++)
    {
        if (min > arbitraryArray[i])
        {
            min = arbitraryArray[i];
        }
    }
    return min;
}
double[] array = arrayGeneration(count, minValue, maxValue);
PrintArray(array);
double maxArrayValue = MaximumArrayNumber(array);
double minArrayValue = MinimumArrayNumber(array);
double result = maxArrayValue - minArrayValue;
Console.WriteLine($"Максимальное значение сгенерированного массива {maxArrayValue}");
Console.WriteLine($"Минимальное значение сгенерированного массива {minArrayValue}");
Console.WriteLine($"Разница (разность) между максимальным и минимальным значением равна {result}");
