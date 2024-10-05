/*
Задайте одномерный массив из 10 целых
чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90].
массив [10 21 14 93 23] => 2
*/


int[] arr = new int[10];
int count = 0;

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 101);
    Console.Write($"{arr[i]} ");
    if (arr[i] >= 20 && arr[i] <= 90)
        {count = count + 1;}
}
System.Console.WriteLine();
System.Console.WriteLine(count);