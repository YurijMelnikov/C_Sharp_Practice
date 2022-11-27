// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите целое число равное или больше 1");
int number = int.Parse(Console.ReadLine());

int [] СubeTable(int number)
{
   
        int[] cubeTableArray = new int [number];
        for (int i = 1; i <= number; i++)
        {
            int n = number - (number - i); 
            cubeTableArray[i-1] = n * n * n;    
        }    
        return cubeTableArray;
}    

void PrintArray (int []array)
{
    Console.WriteLine ($"Таблица кубов от 1 до {number}:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }      
}
if (number >= 1)
{
int [] cubeTableArray = СubeTable(number);
PrintArray(cubeTableArray);
}
else
{
    Console.WriteLine ("Введено не правильное значение, введите целое число равное или больше 1");
}
