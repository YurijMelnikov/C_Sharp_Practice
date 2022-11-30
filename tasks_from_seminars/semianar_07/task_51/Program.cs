// Задача 51: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int countI = 3;
int countJ = 3;
int deviation = 10;
int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

int diagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {      
        sum = sum + array[i,i];
    }
    return sum;
}

void print2dArray(int[,] array) 
{ 
    Console.Write("\t"); 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        printColor(i + "\t",ConsoleColor.DarkYellow); 
    } 
    Console.WriteLine(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        printColor(i+"\t",ConsoleColor.DarkYellow); 
        for (int j = 0; j <  array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j] + "\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

void printColor(string information, ConsoleColor color) 
{ 
    Console.ForegroundColor = color; 
    Console.Write(information); 
    Console.ResetColor(); 
}


int [,] array = generate2DArray (countI, countJ, deviation);
print2dArray(array);
int sum = diagonalSum(array);
Console.WriteLine (sum);