// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число:");
// string palindrom = Console.ReadLine();
// int size = palindrom.Length;
// int i = 0;

// if (palindrom.Length == 5)
// {
//     if (palindrom[i] == palindrom[size - 1] && palindrom[i + 1] == palindrom[size - 2])
//     {
//         Console.WriteLine("Данное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Данное число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введено число не заданного формата");
// }

Console.WriteLine("Введите пятизначное число:");
int palindrom = Convert.ToInt32(Console.ReadLine());
int tenHundred = palindrom / 10000;
int hundred = palindrom / 1000;
int hundredCorrect = palindrom % 10;
int thousend = palindrom / 100;
int thousendCorrect = palindrom % 10;
int tenth = palindrom % 10;

if (tenHundred == tenth && hundredCorrect == thousendCorrect)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}