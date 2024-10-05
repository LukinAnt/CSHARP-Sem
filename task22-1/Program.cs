/*
Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.

массив [6 7 19 34 3 1 4 7 9 1] => 3
массив [1 8 43 4 55 60 3 2 1 3] => 4

*/

int[] arr = new int[10];
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 11);
    Console.Write($"{arr[i]} ");
    if (arr[i] % 2 == 0)
    { count = count + 1; }
}
System.Console.WriteLine();
System.Console.WriteLine(count);


