/*
Задача №7. Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введите трехзначное число");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(n % 10);