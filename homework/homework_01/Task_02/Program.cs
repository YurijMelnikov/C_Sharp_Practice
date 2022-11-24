// Задача 4: Напишите программу, которая принимает
//  на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Нахождение большего рационального числа из трёх \nВведите первое число");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число");
double thirdNumber = double.Parse(Console.ReadLine());
double max = firstNumber;
if (firstNumber == secondNumber && secondNumber == thirdNumber)
    {
        Console.WriteLine ("Все три числа равны");
        return;
    }
if (max < secondNumber)
   {
    max = secondNumber;
    }
    if (max < thirdNumber)
        {
        max = thirdNumber;
        }
Console.WriteLine ($"Из трёх чисел: {firstNumber} {secondNumber} {thirdNumber} \nбольшим является {max}");
    
    