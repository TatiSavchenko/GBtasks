// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Input numbers separated by commas: ");
string[] parameters = Console.ReadLine()!.Split( ",", StringSplitOptions.RemoveEmptyEntries); 

GetResult(parameters);

Console.WriteLine($"Quantity of numbers > 0 = {GetResult(parameters)}");


int GetResult(string [] arr)
{
    int count=0;
    int[] arr1 = Array.ConvertAll(arr, int.Parse);
    
    for(int i=0; i<arr1.Length; i++)
    {
        if(arr1[i]>0)
        {
            count =count+1;
        }
    }
    return count;
}