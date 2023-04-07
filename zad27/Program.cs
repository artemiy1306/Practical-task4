//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumOfDigits(int num)
{
int result=0;
for(; num!= 0; num = num/10)
{
   result = result+num%10;
}
return result;
}
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigits(a);
Console.Write($"{a} => {sum}");