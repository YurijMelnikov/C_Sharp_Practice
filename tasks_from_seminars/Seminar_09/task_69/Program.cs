/* Задача 69: Напишите программу, которая на вход принимает два числа A и B
, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

// Console.WriteLine("Введите первое число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int B = Convert.ToInt32(Console.ReadLine());
// int Degree = 0;
// int DegreeofA(int A, int B)
// {   
//     if (B != 1) 
//     int Degree = A*A;
//     B = B - 1;
//     return Degree;    
// }

// Console.WriteLine (DegreeofA(A,B));

 
int getUserInt(string message) 
{ 
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message); 
    Console.ResetColor(); 
    int userInt = Convert.ToInt32(Console.ReadLine()); 
    return userInt; 
} 
int numberA = getUserInt("Введите число A"); 
int numberB = getUserInt("Введите число B"); 
int degreeOfNumber = printRange(numberA, numberB); 
Console.WriteLine($"Число {numberA} в степени числа {numberB} равно {degreeOfNumber}"); 
int printRange(int numberA, int numberB) 
{ 
    if (numberB <= 0) 
    { 
        return 1; 
    } 
    return numberA * printRange(numberA, numberB - 1); 
}