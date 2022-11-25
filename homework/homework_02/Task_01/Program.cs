// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

static int secondNumber(int number)
{
    if (number < 0) number = -number;
    int result = number % 100;
        result = result / 10;
        return result;
}

Console.WriteLine ("Введите целое трёхзначное число");
int number = int.Parse(Console.ReadLine());
if ((number < -999) || ((number >= -99) && (number <= 99)) || (number > 999))
{
    Console.WriteLine ("Ошибка, вы ввели не трёхзначное число");
    return;
}
int result = secondNumber(number);
Console.WriteLine (result);


