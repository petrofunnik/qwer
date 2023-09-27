// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//-------------------------------

void SecondNumber(int num)
{
    int dec = num / 10;
    int second = dec % 10;
    System.Console.WriteLine(second);
}

System.Console.WriteLine("Input three-digit number: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
SecondNumber(num1);