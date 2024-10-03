/*
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/

/*
nt[]arr = new int[6];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next (1, 11);
    System.Console.Write($"{arr[i]} ");
}

System.Console.WriteLine();

int[]arr2 = new int[3];
for (int i = 0; i < arr.Length/2; i++)
{
    arr2[i] = arr[i] * arr[arr.Length-i-1];
    System.Console.Write($"{arr2[i]} ");
}
// для четного количества
*/
int r = new Random().Next (1, 11);
int[]arr = new int[r];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next (1, 11);
    System.Console.Write($"{arr[i]} ");
}

System.Console.WriteLine();

int[]arr2 = new int[r/2];
for (int i = 0; i < arr.Length/2; i++)
{
    arr2[i] = arr[i] * arr[arr.Length-i-1];
    System.Console.Write($"{arr2[i]} ");
}
