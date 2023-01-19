// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами 
// и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

Console.Clear();
double [] array = GetArray(8);
PrintArray(array);
Console.WriteLine();
double diff = GetDif(array);
Console.WriteLine($"difference between max and min = {diff} ");




double[] GetArray (int size)
{
    double[] arr = new double[size];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()*100;
    }
    return arr;    
}

void PrintArray(double [] arr)
{
    Console.Write($"[");
    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

double GetDif(double[] arr2)
{
    double difference = 0;
    double max = arr2[0];
    double min = arr2[0];
    for(int i=0; i<arr2.Length; i++)
    {
        if(arr2[i]>max)
        {
            max = arr2[i];
        }
         
        if(arr2[i]<min)
        {
            min = arr2[i];
        }
        
        difference = max - min;
    }
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
    return difference;
}









