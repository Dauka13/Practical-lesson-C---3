// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
int size = new Random().Next(1, 11);

Console.WriteLine($"Amount elements of array: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDifference(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Minimal value of array {arr.Min()}, maximum value of array {arr.Max()}");
    Console.WriteLine($"Difference between minimum and maximum array values is {difference}");
    Console.WriteLine();
}
PrintDifference(FillSourceArray(size));
Console.WriteLine();