// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

Console.Clear();
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue+1);
    }
    return array;
}

int[] arr = GetArray(10, 1, 10);

void PrintArray(int[] inArray)
{
    Console.Write(" [");
    for(int i = 0; i < inArray.Length-1; i++)
    {
        Console.Write($"{inArray[i]}, ");
    }
    Console.Write($"{inArray[inArray.Length-1]}]");
}

PrintArray(arr);

int[] GetMulti(int[] array)
{   
    int size = array.Length/2;
    if(array.Length%2 == 1) size++;
    
    int [] multi = new int[size];
    for(int i=0; i<size; i++)
    {
        multi[i]= array[i]*array[array.Length-1-i];
    }
    return multi;
}

int[] arr2 = GetMulti(arr);
PrintArray(arr2);

