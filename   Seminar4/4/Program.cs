﻿/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,\
 заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

*/

void FillAray(int[] collection){

    int length = collection.Length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next(0, 2);
        index ++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}