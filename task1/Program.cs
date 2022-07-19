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
int palindrom = Convert.ToInt32(Console.ReadLine());  // 45658
int tenHundred = palindrom / 10000;  // 45658/10000 = 4 - первая цифра полиндрома
int hundred = palindrom / 1000; // 45658 / 1000 = 45
int hundredCorrect = hundred % 10; // 45%10 = 5 - вторая цифра полиндрома
int thousend = palindrom / 10; // 45658 / 10 = 4565
int thousendCorrect = thousend % 10; // 4565%10 = 5 - четвертая цифра полиндрома
int tenth = palindrom % 10; // 45658%10 = 8 - пятая цифра полиндрома

if (tenHundred == tenth && hundredCorrect == thousendCorrect)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}