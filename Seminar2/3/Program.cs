/*
Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.Write("Input first number => ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input secondnumber => ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 / number1 == 0) 
{
    Console.WriteLine("Второе число кратно первому числу");
}
else
{
    if(number1 != 2 && number2 != 1)
    {
        Console.Writeline("Остаток от дедления второго числа на первое число: "
        +number2 / number1 );
        }
        else
        {
            Console.WriteLine("Ошибка: второе число равно двум или первое чилос равно 1");
        }
}

