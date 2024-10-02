/*
15. Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("цифра деня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

void day (int Number) 
{
  if (Number == 6 || Number == 7) 
  {
  Console.WriteLine("да");
  }
  else 
  Console.WriteLine("нет");
}

day(Number);