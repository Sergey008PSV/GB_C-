//1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Введите первое чиcло ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)

{
    Console.Write("большее число первое " +num1);
     }

else

{
    Console.Write("большее число второе " +num2);
    }