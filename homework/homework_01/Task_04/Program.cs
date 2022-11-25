// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Нахождение всех чётных чисел от 1 до заданного целого числа \nВведите целое число");
int number = int.Parse(Console.ReadLine());
int i = 1;
if (number != 1 && number != -1)
    if (number > 1)
        {          
        Console.WriteLine ($"Чётные числа от 1 до {number}:");
        while (i <= number)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            i+=1;
            }
            }

    else
    {
        i = number;
        Console.WriteLine ($"Чётные числа от {number} до 1:");
        while (i < 1)
            {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        i+=1;
            }
    }
else
{
Console.WriteLine ("Таких чисел нет");
}