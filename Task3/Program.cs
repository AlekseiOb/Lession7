// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ShowArrayRev(int[] arr, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(arr[index] + " ");
    index = index - 1;
    ShowArrayRev(arr, index);
}

void ShowArray(int[] arr)
{
    foreach (var c in arr)
    {
        Console.Write($"{c} ");
    }
    Console.WriteLine();
}

int[] array = { 1, 2, 3, 4, 5 };
Console.WriteLine("Исходный массив:");
ShowArray(array);
Console.WriteLine("\nМассив в обратном порядке:");
ShowArrayRev(array, array.Length - 1);