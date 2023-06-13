/*
Напишите программу, которая на вход принимает
число и выдает его квадрат (число умноженное
на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.Write("Input number => ");
int number = Convert.ToInt32(Console.ReadLine());

int power = 2; // power of number
int squareNumber = (int)Math.Pow (number, power);
Console.WriteLine($"Square {number} is {squareNumber}");
