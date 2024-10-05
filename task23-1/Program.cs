/*
Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива. 

массив [2.2 0.4 9.11 7.2 78.98] => 78.58
массив [1.22 4.5 3.33] => 3.28
*/

Console.Write("Введите массив: ");
int n = Convert.ToInt32(Console.ReadLine());
double max = 0;
double a;
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble() * 100;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
        max = array[i];
}
Console.Write(max);
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
        min = array[i];
}
a = max - min;
Console.WriteLine("  и  " + min);
Console.WriteLine("\n");
Console.WriteLine("разница: ");
Console.WriteLine(a);