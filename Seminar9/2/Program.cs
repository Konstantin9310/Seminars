﻿/*
адача 65: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. 
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" 
*/

string ReturnRealDigits(int number, int startNum){ 
    if(startNum == number) return startNum.ToString(); 
    return startNum + " " + ReturnRealDigits(number, startNum+1); 
} 
Console.Clear(); 
Console.WriteLine(ReturnRealDigits(5,3));