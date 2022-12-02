//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 100)
    Console.WriteLine("Третьей цифры нет!");
else
{
    string x = Convert.ToString(number);
    Console.WriteLine("Третья цифра вашего числа: " + x[2]);
}