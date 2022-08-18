// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreatArray()
{
    int size = 123;
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(0, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int AmountOfNumbers(int[] array)
{
    int quantity = 0;
    foreach(var element in array)
        if(element >= 10 && element <= 99) quantity++;
    return quantity;
}

bool AllNumbers(int amount)
{
    if(amount > 0) return true;
    else return false;
}

Console.Clear();
int[] numbers = CreatArray();
Console.WriteLine("Array");
PrintArray(numbers);

int sum = AmountOfNumbers(numbers);

bool Digit = AllNumbers(sum);
Console.WriteLine(Digit ? $"Amount of elements in segment [10, 99]: {sum}" 
                : "There is no elements in segment [10, 99]");