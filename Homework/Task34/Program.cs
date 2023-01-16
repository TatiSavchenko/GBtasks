// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = array(10);
Fill(arr);
int result = Counting(arr);
Print(arr);
Console.WriteLine($"Quantity of even numbers = {result}");


int [] array (int count)
{
    return new int[count];
}

void Fill(int[] elements)
{
    int length = elements.Length;
    int index = 0;
    
    while(index<length)
    {
        elements[index] = new Random().Next(100,1000);
        index++;
    }
}

int Counting(int [] array2)
{
    int result = 0;
    int size = array2.Length;

    for (int i =0; i<size; i++)
    {
        int current = array2[i];
        if(current%2 == 0)
        {  
            result++;  
        }
    }
return result;
} 

void Print(int[] array3)
{
    for(int i = 0; i<array3.Length; i++)
    Console.Write($"{array3[i]} ");
}

