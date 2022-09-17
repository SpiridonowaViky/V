Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalToLow(numberM, numberN);


void NaturalToLow(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, m + 1);
        Console.Write(m + " ");
    }
}

