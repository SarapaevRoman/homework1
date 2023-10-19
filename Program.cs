//Задача 10.Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа
Console.Write("Ведите трехзначное число ");
string firstNamber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(firstNamber, out number);
int result = (number % 100) / 10;
   
Console.Write(result);
