// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");
int A = Convert.ToInt32(Console.ReadLine());

// int B = (A/10000)%10;
// int C = (A/1000)%10;
// int E = (A/10)%10;

// int D = A%10;
// Console.WriteLine(B);
// Console.WriteLine(C);
// Console.WriteLine(E);

// Console.WriteLine(D);
if ((A/10000)%10 == A%10 && (A/1000)%10 ==(A/10)%10) Console.WriteLine($"{A} -> да");
else  Console.WriteLine($"{A} -> нет");
