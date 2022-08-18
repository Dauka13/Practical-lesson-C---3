// Написать программу замену элементов массива на противоположные

int[] CreateArray(int size)
{
    var array = new int [size];
    var random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int[] Replace(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.Clear();
Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] Numbers = CreateArray(length);

Console.WriteLine("Given array: ");
PrintArray(Numbers);

int [] Numbers2 = Replace(Numbers);
Console.WriteLine("Reverse array: ");
PrintArray(Numbers2);