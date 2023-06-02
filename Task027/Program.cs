// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int DisassembleNum (int number)
{
    int remains = 0;
    int sum = 0;

    while (Math.Abs(number) > 0)
    {
        remains = number % 10;
        Console.Write($"{Math.Abs(remains)} ");
        sum = sum + remains;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("Введите число: ");
int sum = DisassembleNum(number);
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {Math.Abs(number)} равно {Math.Abs(sum)}");