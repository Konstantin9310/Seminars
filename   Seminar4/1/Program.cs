﻿/*
Задача 24: Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

int GetNumber (string description){
    int number;
    Console.Write($"{description} =>" );

    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number \"{temp}\" is not correct. Try again  =>" );
    }
}

int Getsum(int number)
{
    int sum = 0;

    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

//int number = GetNumber("input number");
//Console.WriteLine(GetNumber($"Sum numbers from 1 to {number} is {Getsum(number)}."));

int [] array = {4, 3, 8, 9};

Console.WriteLine(string.Join(", ", array));