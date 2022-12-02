//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введите число искомого дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 7 || number == 6)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
