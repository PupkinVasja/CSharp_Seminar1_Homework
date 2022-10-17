
//Задача 2. Напишите программу, которая на входе принимает два числа, и выдает, какое число большее, а какое меньшее.


Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2){
    Console.WriteLine($"{num1} < {num2}");
}
else {
    if (num1 == num2){
        Console.WriteLine($"{num1} = {num2}");
    }
    else {
        Console.WriteLine($"{num1} > {num2}");
    }
    
}