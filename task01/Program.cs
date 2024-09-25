/*
Напишите программу, которая на вход принимает два числа 
и проверяет, является ли первое число квадратом второго
25 и 5 да
2 и 10 нет
9 и 3 да
-3 и 9 нет
*/

Console.WriteLine("введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("НЕявляется");
}
