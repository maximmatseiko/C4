// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трёхзначное число :");
int NumA=Convert.ToInt32(Console.ReadLine());
string Num=Convert.ToString(NumA);
System.Console.WriteLine("Вторая цыфра :"+ Num[2]);