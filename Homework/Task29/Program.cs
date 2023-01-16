// Задача 29: Напишите программу, реализующую метод, 
// который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

Console.Clear();
int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] elements)
{
    int length = elements.Length;
    int index = 0;

    while(index < length)
    {
        int current = Random.Shared.Next(100);
        elements[index] = current;
        index ++;
    }
}

string Print(int[] collection)
{
    string output = String.Empty;
    int size = collection.Length;
    int index = 0;
    while(index < size)
    {
        int current = collection[index];
        output = output + $"{current} ";
        index++;
    }
    return output;
}

int[] arr = CreateArray(8);
Fill(arr);
Console.WriteLine(Print(arr));
