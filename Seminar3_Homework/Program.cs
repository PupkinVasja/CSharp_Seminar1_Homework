
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void checkPalindrome (int n){

int firstDigit;
int secondDigit;
int fourthDigit;
int fifthDigit;

firstDigit = n / 10000;
fifthDigit = n % 10;
secondDigit = (n / 1000) - firstDigit*10;
fourthDigit = ((n % 100) - fifthDigit) / 10;

if (firstDigit == fifthDigit & secondDigit == fourthDigit){
    Console.WriteLine("YES, this number is a palindrome!");
}
else{
    Console.WriteLine("NO, this number is not a palindrome!");
}
}

Console.Write("Enter 5-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 10000 & n < 100000){
    checkPalindrome (n);
}
else{
    Console.WriteLine("This is not 5-digit number!");
}




// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве: AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

// A (3, 6, 8); B (2, 1, -7), -> 15.84
// A (7, -5, 0); B (1, -1, 9) -> 11.53

/*
double Distance(int xa, int xb, int ya, int yb, int za, int zb){
    double ab = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za));
    return ab;
}

Console.Write("Введите xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ya: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите za: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите xb: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yb: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());

double result = Distance(n1, n4, n2, n5, n3, n6);

Console.WriteLine($"The distance between these points is {result}");
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void Cubes(int n){
    for(int i = 1; i <= n; i++){
        Console.Write($"{i*i*i} ");
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cubes(n);
*/