/*
16.Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/


Console.WriteLine("введите 2 числa: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 * number1 == number2 || number2 * number2 == number1) 
if (Math.Pow (number1, 2) == number2 || Math.Pow (number2, 2) == number1) // возведение в степень
{ 
    Console.WriteLine("да"); 
}   
else 
{ Console.WriteLine("нет"); }