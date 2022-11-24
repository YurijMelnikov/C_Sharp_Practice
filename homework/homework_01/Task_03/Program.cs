// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Проверка целого числа на чётность \nВведите целое число");
int number = int.Parse(Console.ReadLine());
int modulo = number % 2;
if (modulo == 0)
    {
        Console.WriteLine ($"Число {number} является чётным");
    }
    else
    {
    Console.WriteLine ($"Число {number} не является чётным");
    }