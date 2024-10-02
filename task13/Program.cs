/*
13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("введите трех и более значное число число:");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number.ToString().Length;
if (number2 >= 3) {
	while (number > 999)
	{
		number = number / 10;
	}
	int result = number % 10;
	Console.WriteLine("третье число " + result);
} else {
	Console.WriteLine("третьей цифры нет");
}