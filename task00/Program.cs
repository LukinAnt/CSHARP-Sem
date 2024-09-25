/* Напишите программу, которая на вход принимает 
число и выдает его квадрат
4 - 16
-3  9
-7  49 */


Console.WriteLine("введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
// из консоли все что ввели нужно сконвертировать в число и запомнил в int number

int result = number * number;
Console.WriteLine(result);