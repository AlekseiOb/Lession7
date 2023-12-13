// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckerFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckerFunc(m - 1, 1);
    }
    else
    {
        return AckerFunc(m - 1, AckerFunc(m, n - 1));
    }
}

int m = 3;
int n = 1;
int res = AckerFunc(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m}, n = {n}: {res}");