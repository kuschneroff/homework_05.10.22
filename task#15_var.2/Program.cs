int number = new Random().Next(1,7);
Console.WriteLine(number);

if(number >= 1 && number<=5)
Console.Write("не выходной");
else if(number == 6 || number == 7)
Console.Write("выходной");
else
Console.Write("ввели не правильный день недели");