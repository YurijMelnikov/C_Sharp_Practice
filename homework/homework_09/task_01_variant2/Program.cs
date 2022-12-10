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


void PrintNaturalNumbers(int number)
{
    if (number >= 2)
    {

        Console.Write(number + ", ");
        PrintNaturalNumbers(number - 1);

    }
    
    return;
}

Console.Write($"Вывод всех натуральных чисел от {N} до 1\n[");
PrintNaturalNumbers(N);
Console.Write("1]");