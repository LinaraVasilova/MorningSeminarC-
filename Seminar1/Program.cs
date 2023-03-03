//First seminar ended
// int num1 = -12;
// int num2 = 6;
// double bigNum = -12.13;
// bool isEven = true;
// string word = "flower";
// Char symbol = '$';

// Console.Write("My numbers are " + (num1 + num2) + " and it is good!");
// Console.WriteLine ($"My numbers are {num1} and {num2} and it is good!");

// Console.Write ("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Your number is " + num);

// HomeWork1

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго


// Console.Write ("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if(num1==quad2)
//     Console.Write("Yes!");
// else
//     Console.Write("No!");



//Task2. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = -num;

// while (current <= num)
// {
//    Console.Write (current + " ");
//    current++; 
// }

// 31542 / 10 = 3154
// 31542 / 100 = 315
// 31542 / 1000 = 31
// 31452 / 10000 = 3

// 31542 % 10 = 2
// 31542 % 100 = 42
// 31542 % 1000 = 542
// 31452 % 10000 = 1542

// 453216 ->32

//Домашнее задание
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
Console.Write ("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());


if(a>b)
    Console.Write("max=" + a);
else if (a<b)
    Console.Write("max=" + b);
*/

// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write ("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max=num1;

if(num2>max && num2>num3)
    Console.Write("max=" + num2);
    else if (num3>max && num3>num2)
        Console.Write("max=" + num3);
    else Console.Write ("max=" + num1);
*/

//Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write ("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());


if(num % 2 == 0)
    Console.Write("да");  
else
    Console.Write("нет");
*/

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int x=1; x<=num; x++)

if (x%2==0)
   Console.Write (x + ",");
*/