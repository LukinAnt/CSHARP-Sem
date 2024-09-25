/*Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17*/

Console.WriteLine("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine(number%10);
}
else
{
    Console.Write("введите трехзначное число");
}