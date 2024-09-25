/*02 напишите программу, которая на вход 
принимает два числа и выдаеткакое число больше
5 и 7   7
2 и 10 10
-9 и -3   -3*/

Console.WriteLine("введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2 )
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}
