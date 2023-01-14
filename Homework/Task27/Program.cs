// Напишите программу, реализующую метод, который принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits of number = {Sum(n)}");

int Sum(int N)
{
    int result = 0;

    while(N>0)
    {
        int digit = N%10;
        result=result+digit;

        N = N/10;
    }
    return result;
}