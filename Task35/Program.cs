// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] array(int size)
{
    return new int[size];
}

void Fill(int [] elements)
{
    for(int i=0; i<elements.Length; i++)
    {
        int current = Random.Shared.Next(123);
        elements[i] = current;
    }
}

int GetQuantity(int [] array)
{
    int quantity=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>10 && array[i]<100)
        {
            quantity+=1;
        }    
    }
    return quantity;
}

void PrintArray(int[] arr1)
{
    Console.Write("[ ");
    for(int i=0; i<arr1.Length-1; i++)
    {
        Console.Write($"{arr1[i]} ");
    }
    Console.Write($"{arr1[arr1.Length-1]} ] ");
}



int[] arr = array(123);
Fill(arr);
PrintArray(arr);
int quantity= GetQuantity(arr);
Console.WriteLine($"{quantity}");