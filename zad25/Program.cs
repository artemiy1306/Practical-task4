//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write($"Введите число A : ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число B : ");
int numB = Convert.ToInt32(Console.ReadLine());  

void Degree(int a, int b)
{
   int result = a;
for(int count=1;count<b;count++)
{
 result = result*a;
}
Console.WriteLine(result);
}

Degree(numA,numB);