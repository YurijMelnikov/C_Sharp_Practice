// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
 Console.WriteLine ("Инициализация массива целых чисел, состоящего из 8 элементов");
int[] ArrayInitialization()
{   
    int[] array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine ($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());        
    }
    return array;
}
void PrintArray (int []arbitraryArray)
{
    Console.WriteLine ("Вывод введённого массива");
    Console.Write ($"[{arbitraryArray[0]}, ");

    for (int i = 1; i < arbitraryArray.Length-1; i++)
    {
        Console.Write ($"{arbitraryArray[i]}, ");
    }
    Console.Write ($"{arbitraryArray[7]}]");      
}
int [] array = ArrayInitialization();
PrintArray (array);