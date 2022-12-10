/*Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.WriteLine("Введите первое число интервала");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число интервала");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int M, int N)
{
    if (N >= M)
    {
        Console.Write(M+","+" ");
        M = M + 1;
        PrintNumbers(M, N);
                
    }
    
}


if (M > N)
{
    PrintNumbers (N, M);
} 
else
{
    PrintNumbers(M, N);
}