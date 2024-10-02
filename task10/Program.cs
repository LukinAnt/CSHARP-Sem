/*
10. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторуюцифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <1000)
{
int num = (number % 100 ) / 10;
System.Console.WriteLine($"Вторая цифра {num}");
}
else
System.Console.WriteLine("Это число не трехзначное");