// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

static string ThirdNumber(int number)
{
    
    {
    if (number < 0) number = -number;
        if ((number > 99) || (number < -99))
        {
        string numberToString =  Convert.ToString(number);
        string result = numberToString[2] + "";
        return result;
        }
        else
        {
            string result = "В числе третьей цифры нет";
            return result;
        }
        }

}

Console.WriteLine ("Введите целое число");
int number = int.Parse(Console.ReadLine());
string result = ThirdNumber(number);
Console.WriteLine (result);