/*
Напишите программу, которая принимает на вход число и п
роверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

void GetNumber()
{
    Console.Write(" Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num%7==0 && num%23 ==0)
    {
        Console.Write(" кратное ");
    }
    else
    {
        Console.WriteLine(" не кратное ");
    }

}
GetNumber();
