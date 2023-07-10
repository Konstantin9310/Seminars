/*
Задача 69: Напишите программу, которая на вход принимает два 
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int Print(int m, int n){
    if(n == 0) return 1;
    return m * Print(m, n-1);
}
Console.WriteLine(Print(m, n));