// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine ("Введите целое число");
int number = int.Parse(Console.ReadLine());
int SumNumber(int integerAnyNumber)
{
    if (number > 0)
    {
        int sum = 0;
        int num = number;
        for (int n = 10; num  != 0; n = n * 10)
        {    
            sum = sum + (num % 10);
            num = number / n;
        }
        return sum;
    }
    else
    {
        int sum = 0;
        int num = number;
        for (int n = 10; num  != 0; n = n * 10)
        {    
            sum = sum + (num % 10);
            num = number / n;
        }
        return -sum;
    }
}

int result = SumNumber(number);

Console.WriteLine ($"Сумма цифр в числе {number} равна {result}");
