// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNatNum(int first, int end)
{
    if (first > end)
    {
        return;
    }
    Console.Write(first+" ");
    ShowNatNum(first + 1, end);
}

int m = 4;
int n = 15;
Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
ShowNatNum(m, n);