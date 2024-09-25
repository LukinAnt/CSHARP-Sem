/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(10, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int second = number % 10;

//int number3 = first * 10 + second;
//System.Console.WriteLine(number3);

System.Console.WriteLine(first * 10 + second);
