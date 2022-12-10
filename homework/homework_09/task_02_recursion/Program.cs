/*Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int sum = 0;
int SumNaturalElements(int number1, int number2)
{

    if (number1 < number2)
    {
        if (number1 != number2)
        {
            sum = sum + (number2);
            SumNaturalElements(number1, number2 - 1);
        }
        return sum;
    }
    else
    {
        if (number2 != number1)
        {
            sum = sum + (number1);
            SumNaturalElements(number1 - 1, number2);
        }
        return sum;
    }
}


Console.WriteLine("Введите первое целое число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int N = int.Parse(Console.ReadLine());


if (M < 1 && N < 1)
{
    Console.WriteLine($"В промежутке между {M} и {N} натуральных элементов нет");
    return;
}


int number1 = M;
int number2 = N;


if (number1 < 1)
{
    number1 = 0;
}
if (number2 < 1)
{
    number2 = 0;
}

sum = SumNaturalElements(number1, number2);
Console.WriteLine($"Сумма натуральных элементов между {M} и {N} равна {sum}");