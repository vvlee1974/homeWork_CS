﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
АЛГОРИТМ
Ввод целого числа (int)
????????????????????????????????????????????????? Проверяем - является ли введённое символы целым числом
Проверяем - делится ли число на 2 с остатком (%)
Выводим "чётное", если делится без остатка
Выводим "нечётное", если делится с остатком
*/

Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if((a % 2) > 0)
{
    Console.Write($"{a} - нечётное число");
}
else
{
    Console.Write($"{a} - чётное число");
}