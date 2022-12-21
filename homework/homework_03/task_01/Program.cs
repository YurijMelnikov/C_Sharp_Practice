// Напишите программу, которая принимает на вход
//  пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool PalindromeCheck(int number)
{
    int newnumber = 0;
    for (int i = 1; i <= 10000; i = i * 10)
    {
        int mod = (number / i) % 10;
        newnumber = newnumber + mod * (10000 / i);
    }
    if (number == newnumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.WriteLine("Введите целое пятизначное число");
int number = int.Parse(Console.ReadLine());
if ((number < 10000 || number > 99999) && (number < -99999 || number > -10000))
{
    Console.WriteLine($"Число {number} не является пятизначным.\nВведите пятизначное число");
}
else
{
    if (PalindromeCheck(number))
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}