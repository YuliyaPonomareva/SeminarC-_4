// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void RaiseToDegree (int numA, int numB)
{
        double Num = Math.Pow(numA, Math.Abs(numB));
        Console.Write($"{numA}^{Math.Abs(numB)} = {Num}");
}
int numA = Prompt("Введите число: ");
int numB = Prompt("Введите число: ");
RaiseToDegree(numA, numB);
