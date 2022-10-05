/*Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 до 7");
string number = Console.ReadLine();
if (number == "1")
    {
    Console.WriteLine("Понедельник");
    Console.WriteLine("1-ый день недели - БУДНИЙ день");
    }
else
    Console.WriteLine("Вы ввели цифру не от 1 до 7. Попробуйте еще раз! У Вас обязательно получится!");
if (number == "2")
    {
        Console.WriteLine("Вторник");
        Console.WriteLine("2-ой день недели - БУДНИЙ день");
    }  
if (number == "3")
    {
        Console.WriteLine("Среда");
        Console.WriteLine("3-ий день недели - БУДНИЙ день");
    } 
if (number == "4")
    {
        Console.WriteLine("Четверг");
        Console.WriteLine("4-ый день недели - БУДНИЙ день");
    }
if (number == "5")
    {
        Console.WriteLine("Пятница");
        Console.WriteLine("5-ый день недели - БУДНИЙ день");
    }
if (number == "6")
    {
        Console.WriteLine("Суббота");
        Console.WriteLine("6-ой день недели ВЫХОДНОЙ");
    }    
if (number == "7")
    {
        Console.WriteLine("Воскресенье");
        Console.WriteLine("7-ой день недели ВЫХОДНОЙ");
    }