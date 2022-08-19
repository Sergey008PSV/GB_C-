//1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

//Console.Write("Введите первое чиcло ");

//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите второе чиcло ");

//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)

//{
//   Console.Write("большее число первое " +num1);
//     }

//else

//{
//    Console.Write("большее число второе " +num2);
//}




// 2. Напишите программу, которая принимает на вход 3 числа и выдает максимальное.

 /* Console.Write("Введите первое чиcло ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье чиcло ");

int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>=num2 && num1>=num3)
{
    Console.Write("большее число : " +num1);
}
else
if (num2>num1 && num2>=num3)
{
    Console.Write("большее число : " +num2);
}
else
if (num3>num1 && num3>num2)
{
    Console.Write("большее : " +num3);
} 
 */




/* // Напишите программу, которая на вход принимает число и выдает, является ли число четным(делиться ли оно на два без остатка).

Console.Write("Введите чиcло ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2.0 == 0.0)
{
    Console.Write("число четное");
}
else
{
    Console.Write("число нечетное");
} */






/* // 4. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите чиcло больше 1 ");

int num = Convert.ToInt32(Console.ReadLine());

int x=1;
 while (x <= num)
{
if (x % 2 != 1)
{
Console.Write(x + " " );
}
x++;
} */






/* //5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа..

int number1 = new Random().Next(100,1000);
Console.WriteLine(number1);
Console.WriteLine(((number1-number1%10)/10)%10); */



/* //6. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

Console.Write("Введи число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
} */





/* //7.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)
{
    Console.WriteLine("Этот день выходной");
}
else

if (a > 0 || a < 8)
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
 */
