// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sum = GetSum(number);
Console.WriteLine($"Sum number 1...A = {sum}");

int GetSum(int A)
{
    int result = 0;
    while(A>0)
    {
        result+=A;
        A--;
    }
    return result;
}