
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


//void thirdDigitFinder (int number)
/*

int tempNumber = number;
int numberOfDigit = 0;
int divider1 = 1;
int divider2 = 1;
int thirdDigit;

while (tempNumber > 0)
{
    tempNumber = tempNumber / 10;
    numberOfDigit = numberOfDigit + 1;
}

int multiplier1 = numberOfDigit - 2;
int multiplier2 = numberOfDigit - 3;


divider1 = numberOfDigit - 2;
divider2 = numberOfDigit - 3;
thirdDigit = number % 

/*
Console.Write("Enter int number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < -100 & number > 100)
{
    thirdDigitFinder(number);
}
else
{
    Console.WriteLine($"Number {number} does not have third digit");
}
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным (+проверка ввода правильного значения).

//6 -> да
//7 -> да
//1 -> нет

void Check (int numberOfDay)
{
    if (numberOfDay < 6)
    {
        Console.WriteLine("No, this day is a working day :(");
    }
    else
    {
        Console.WriteLine("Yes, this day is a weekend :D");
    }
} 

Console.Write("Enter the number of the day of the week (1-7): ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

if (numberOfDay > 0 & numberOfDay < 8)
{
    Check(numberOfDay);
}
else
{
    Console.WriteLine("Incorrect number of the day of the week!");
}