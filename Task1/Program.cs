//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
void secondNumber()
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = number % 100;
    Console.WriteLine($"Вторая цифра введённого вами числа - {number / 10}");
}
secondNumber();