// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Input a number A: ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B: ");
int B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Pow(A1,B1));

int Pow(int A,int B)
{
    int result = 1;
    
    for(int count = 0; count != B; count++)
    {
        result= result*A;
    } 
    return result;
}


