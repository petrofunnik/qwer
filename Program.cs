﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//-------------------------------

// void SecondNumber(int num)
// {
//     int dec = num / 10;
//     int second = dec % 10;
//     System.Console.WriteLine(second);
// }

// System.Console.WriteLine("Input three-digit number: ");
// int num1 = Convert.ToInt32(System.Console.ReadLine());
// SecondNumber(num1);
//------------------------------------------------------



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//-----------------------------


void ThirdNumber(int num)
{
    while (num / 100 == 0)
    {
        int num1 = num / 10;
    }
    if (num / 10 == 0)
    {
        System.Console.WriteLine("третьей цифры нет");
    }
    int third = num1 % 10;
    System.Console.WriteLine(third);
}
System.Console.WriteLine("input number: ");
int num = Convert.ToInt32(System.Console.ReadLine());
ThirdNumber(num);



//------------------------


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//--------------------------------


// void week(int num)
// {
//     if (num == 6 || num == 7)
//     {
//         System.Console.WriteLine("Да");
//     }
//     else
//     {
//         System.Console.WriteLine("нет");
//     }
// }

// System.Console.WriteLine("Input day of week: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// week(num);