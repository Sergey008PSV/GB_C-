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




// 8. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");




//Задача 9: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("\n Задача 23");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
