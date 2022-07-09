// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string palindrom = Console.ReadLine();
int size = palindrom.Length;
int i = 0;

if (palindrom.Length == 5)
{
    if (palindrom[i] == palindrom[size - 1] && palindrom[i + 1] == palindrom[size - 2])
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено число не заданного формата");
}