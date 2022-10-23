
//Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру 
// этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
void Cutter (int threeDigitNumber)
{
    int hundreds = threeDigitNumber / 100;
    int eds = threeDigitNumber % 10;
    int decimes = (threeDigitNumber - hundreds*100 - eds) / 10;
    Console.WriteLine($"The second digit of number {threeDigitNumber} is {decimes}.");
}


Console.Write("Enter three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber >= 100 & threeDigitNumber < 1000)
{
    Cutter (threeDigitNumber);
}
else
{
    Console.WriteLine ("This is not a three-digit number!");
}
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6






//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным (+проверка ввода правильного значения).

//6 -> да
//7 -> да
//1 -> нет






//Задача 2: Напишите программу, которая на входе принимает два числа и выдает, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2){
    Console.WriteLine($"max = {num2}");
}
else {
    if (num1 == num2){
        Console.WriteLine($"{num1} = {num2} these numbers are the same");
    }
    else {
        Console.WriteLine($"max = {num1}");
    }
    
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write("Enter first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third int number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max){
    max = num2;
}
if (num3 > max){
    max = num3;
}
Console.WriteLine($"Max number is: {max}");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("Enter int number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine($"yes, {num} is even number");
}
else{
    Console.WriteLine($"no, {num} is odd number");
}
*/  


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("Enter positive int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;

while(index <= num){
    Console.Write($"{index}, ");
    index = index + 2;
}
Console.WriteLine("End");
*/