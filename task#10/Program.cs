/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

void SecondNumberIn()
{
    int number = (new Random().Next(100,1000));
    Console.WriteLine($" Сгенерированное рандомное трехзначное число = {number}");
    string numberAsString = number.ToString();
    int result = int.Parse(numberAsString[1].ToString());
    Console.WriteLine($" Вторая цифра в трехзначном числе = {result}");
}
SecondNumberIn();