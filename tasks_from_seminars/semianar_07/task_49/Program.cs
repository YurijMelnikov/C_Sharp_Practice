// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int countI = 10;
int countJ = 10;
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

int[,] squareArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 || j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }   
    }
    return array;
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


int [,] array = generate2DArray(countI, countJ, deviation);
int[,] squarearray = squareArray(array);
print2dArray (squarearray);