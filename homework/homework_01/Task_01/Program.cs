// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("Нахождение большего из двух рациональных чисел \nВведите первое число\n");
double firstNumber = double.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число");
double secondNumber = double.Parse (Console.ReadLine());
if (firstNumber == secondNumber)
    {
    Console.WriteLine ($"{firstNumber} = {secondNumber}, оба числа равны");
    }
    if (firstNumber > secondNumber)
    {
        Console.WriteLine ($"{firstNumber} большее число");
    }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine ($"{secondNumber} большее число");
        }