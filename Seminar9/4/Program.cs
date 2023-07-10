/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void Print(int m, int n){
    Console.WriteLine(m);
    if(m < n) Print(m+1, n);
}
Print(m, n);