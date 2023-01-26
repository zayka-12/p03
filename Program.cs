// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int DeleteSecondDigit(int number)
{
  int a = number / 100;
  int b = number % 10;
  int result = a * 10 + b;
  return result;
}

// int gen = 0;
// while(gen < 101)
// {
int i = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано число: {i}");
Console.WriteLine($"Новое число без второй цифры: {DeleteSecondDigit(i)}");











