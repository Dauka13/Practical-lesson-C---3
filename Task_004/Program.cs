// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] CreatArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int UnevenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = CreatArray(length);
Console.WriteLine("Array: ");
PrintArray(numbers);
int QuantityOfEvenNumbers = EvenNumbers(numbers);
int QuantityOfUnvenNumbers = UnevenNumbers(numbers);
Console.WriteLine($"In array {QuantityOfEvenNumbers} even numbers and "
                + $"{QuantityOfUnvenNumbers} uneven numbers");