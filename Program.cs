// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Imput a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine(a + " the largest number");
}
else
{
    Console.WriteLine(b + " the largest number");
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Imput a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("Max number: " + max);
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Imput a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Да, число четное: " + a);
}
else
{
    Console.WriteLine("Нет, число не четное: " + a);
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Imput a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 2)
{
    Console.WriteLine("Нет четных чисел!");
}

int i = 1;

while(i < a)
{   
    if(i % 2 == 0)
    {
        Console.WriteLine(i + " ");
 
    }
    i++;
}
*/

