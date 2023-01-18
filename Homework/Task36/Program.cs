// Задача 36: Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
int[] array = GetArray(10, 1, 9);
PrintArray(array);
int Sum1= GetSum(array);
Console.WriteLine($"Value sum ={Sum1} ");




int [] GetArray(int size, int minValue, int maxValue)
{
    int[] array= new int[size];
    for(int i=0; i< array.Length; i++)
    {
        array[i]= new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int GetSum(int[] arr)
{
    int Sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(i%2!=0)
        {
            Sum+=arr[i];
        }
    }
    return Sum;
}

void PrintArray(int[] arr2)
{
    Console.Write("[");
    for(int i=0; i<arr2.Length-1; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
    Console.Write($"{arr2[arr2.Length-1]}] ");
}