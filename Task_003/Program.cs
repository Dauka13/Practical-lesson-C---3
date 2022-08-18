// Определить, присутствует ли в заданном массиве, некоторое число

int[] CreatArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

bool SearchNumber(int[] array, int find)
{
    foreach (var element in array)
        if (element == find) 
            return true;
        return false;
}

Console.Write("Enter length of array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] searchArray = CreatArray(size);

Console.WriteLine("Array contains:");
PrintArray(searchArray);

Console.Write("Enter number to search: ");
int number = int.Parse(Console.ReadLine() ?? "0");

bool findNumber = SearchNumber(searchArray, number);

Console.WriteLine(findNumber ? $"Number {number} found " :
                        "This number isn't here.");