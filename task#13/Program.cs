﻿/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 
*/

Console.WriteLine("Введите не двухзначное число");
Console.WriteLine();   
string ThirdNumber = Console.ReadLine();
if(ThirdNumber.Length > 2)
    {
        Console.WriteLine($" Третья цифра в указанном числе = {ThirdNumber[2]}");
    }
else{
        Console.WriteLine($"Введено двухзначное число. Неообходимо ввести число, содержащее три или более цифр в себе");
    }