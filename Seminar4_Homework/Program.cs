// Задача 25: напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 0, 0 -> 1
// 2, 4 -> 16


void ToThePowerOfNumber (int num, int power)
{
    int result = num;
    for (int i = 1; i < power; i++)
    {
        result = result * num;
    }
    Console.WriteLine($"{num} raised to the power of {power} is {result}.");
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of power: ");
int power = Convert.ToInt32(Console.ReadLine());

if (power != 0)
{
    ToThePowerOfNumber (num, power);
}
else
{
    Console.WriteLine($"{num} raised to the power of 0 is 1.");
}



// Задача 27: напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int summOfDigit (int n)
{

    int i = 0;
    int tempN = n;
    int summ = 0;

    while (n != 0)
    {
        tempN = n % 10;
        n = n / 10;
        summ = tempN + summ;
        i++;
    }

    if (summ >= 0)
    {
        return summ;
    }
    else
    {
        return summ * -1;
    }
}

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of the digits of the number {n} is {summOfDigit(n)}.");
*/


// Задача 29: напишите программу, которая создаёт массив заданного пользоватетлем размера, заполняет массив элементами 
// от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int [] CreatRandArray (int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b] ");
}

Console.Write("Enter array length: ");
int length = Convert.ToInt32(Console.ReadLine());

PrintArray(CreatRandArray(length));
*/