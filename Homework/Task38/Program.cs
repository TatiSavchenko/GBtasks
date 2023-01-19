// Задача 38: Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами 
// и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

Console.Clear();
double [] array = GetArray(8);
PrintArray(array);
Console.WriteLine();
double diff = GetDif(array);
Console.WriteLine($"difference between max and min = {diff:f2}");




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
        Console.Write($" {arr[i]:f2} ");
    }
    Console.Write($"{arr[arr.Length-1]:f2}]");
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
Console.WriteLine($"max = {max:f2}");
Console.WriteLine($"min = {min:f2}");
    return difference;
}


// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }






