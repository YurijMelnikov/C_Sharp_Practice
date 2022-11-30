// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которые вы собираетесь ввести");
int count = int.Parse(Console.ReadLine());
double[] InputArray(int arrayLength)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}
int QuantityOfPositiveNumbers(double[] InputArray)
{
    int quantityOfPositiveNumbers = 0;
    for (int i = 0; i < count; i++)
    {
        if (InputArray[i] > 0)
        {
            quantityOfPositiveNumbers = quantityOfPositiveNumbers + 1;
        }
    }
    return quantityOfPositiveNumbers;
}
double [] inputArray = InputArray(count);
int quantityOfPositiveNumbers = QuantityOfPositiveNumbers(inputArray);
Console.WriteLine ($"Количество введённых положительных чисел равно {quantityOfPositiveNumbers}");
