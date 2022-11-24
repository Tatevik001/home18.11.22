// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number < 100000) 
if ((number / 10000 == number % 10) && (number / 1000) % 10 == (number % 100) / 10)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
else
{
    Console.WriteLine("error: Вы ввели не пятизначное число");
}
