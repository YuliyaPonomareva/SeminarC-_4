// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int count = int.Parse(Console.ReadLine()!);
    return count;
}


void RandomArray(int count)
{
    int [] array = new int [count];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write ($"{array[i]} ");
    }
}

int count = Prompt("Введите число: ");
RandomArray(count);
