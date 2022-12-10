/*Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


int AckermannFunction(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
        if (number1 != 0 && number2 == 0)
        {
            return AckermannFunction(number1 - 1, 1);
        }
            if (number1 > 0 && number2 > 0)
            {
                return AckermannFunction(number1 - 1, AckermannFunction(number1, number2 - 1));
            }
    else
    {
    return -1;
    }
}

Console.WriteLine("Введите первый аргумент функции Аккермана (целое, не отрицательное число)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй аргумент функции Аккермана (целое, не отрицательное число)");
int n = int.Parse(Console.ReadLine());
int result = AckermannFunction(m,n);
if (result == -1)
    {
        Console.WriteLine ("Вы ввели не корректные значения для вычисления функции Аккермана,\nоба аргумента функции должны быть не отрицательными и целыми числами");
        return;
    }
Console.WriteLine($"Значение функции Аккермана А({m},{n}) равно {result}");