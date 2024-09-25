/*
напишите программу, которая на вход принимает число 
и выдает является ли число четным(делится ли оно на 2 без остатка
)
*/

Console.WriteLine("введите 1 число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number % 2;
if(number2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}