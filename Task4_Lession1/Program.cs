﻿/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
АЛГОРИТМ
Ввод первого целого числа (int)
Ввод второго целого числа (int)
Ввод третьего целого числа (int)
????????????????????????????????????? Проверяем - являются ли введённые символы целыми числами (int)
Сравниваем два числа и определяем максимальное из них (max_12)
Сравниваем определившийся (max_12) с третьим числом и определяем новый (max_3)
Выводим итоговый (max)
*/

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine() ?? "0");

int max_12 = 0;
int max_3 = 0;



if(a > b)
{
    max_12 = a;
}
else
{
    max_12 = b;
}

if(c > max_12)
{
    max_3 = c;
}
else
{
    max_3 = max_12;
}

Console.WriteLine($"max = {max_3}");