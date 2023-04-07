//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] newArray)
{
    Console.Write("Массив: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 30);
        Console.Write($"{newArray[i]}, ");
    }
}

int[] array = new int[8];
FillArray(array);