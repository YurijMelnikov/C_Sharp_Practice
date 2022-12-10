/*Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/




int SumNaturalElements(int number1, int number2)
{

    if (number1 < 1)
    {
        number1 = 0;
    }
        if (number2 < 1)
        {
            number2 = 0;
        }
            if (number1 > number2)
            {
                int sum = 0;
                for (int i = 0; (number1 - i) >= number2; i++)
                {
                    sum = sum + (number1 - i);
                }
                return sum;
            }
            else
            {
                int sum = 0;
                for (int i = 0; (number2 - i) >= number1; i++)
                {
                    sum = sum + (number2 - i);
                }
                return sum;
            }
}


Console.WriteLine("Введите первое число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = int.Parse(Console.ReadLine());


if (M < 1 && N < 1)
{
    Console.WriteLine($"В промежутке между {M} и {N} натуральных элементов нет");
    return;
}


int sum = SumNaturalElements(M, N);
Console.WriteLine($"Сумма натуральных элементов между {M} и {N} равна {sum}");