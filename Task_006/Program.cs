// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
int size = 10;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of numbers, which stayed on the uneven position {sum} ");
    Console.WriteLine();
}

PrintArray(FillArray(size));