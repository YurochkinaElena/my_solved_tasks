﻿// Домашняя работа. Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom()
{
    int num1 = number % 10;
    int num2 = number % 100 / 10;
    int num3 = number % 1000 / 100;
    int num4 = number % 10000 / 1000;
    int num5 = number / 10000;

    return (num1 == num5 && num2 == num4);

}
Console.WriteLine(Palindrom() ? "Данное число палиндромом" : "Число не является палиндромом");