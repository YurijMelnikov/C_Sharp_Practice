// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

static string DayOff(int number)
{
if (number < 1 || number > 7) 
{
string result = "Введён не корректный день недели, введите номер дня недели с 1 до 7";
return result;
}
else
{
    if (number == 6 || number == 7)
        {
        string result = "Этот день недели выходной";
        return result;
        }
    else
    {
        string result = "Этот день недели рабочий";
        return result;
    }
}
}

Console.WriteLine ("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());
string result = DayOff(number);
Console.WriteLine (result);