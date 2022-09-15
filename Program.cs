//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] ShortStringsOnly(string[] arr, int size)
{
    int count = -1;
    string[] result = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= size)
        {
            count++;
            result[count] = arr[i];
        }
    }
    Array.Resize<string>(ref result, count + 1);
    if (count == -1) Console.WriteLine($"\nGiven array does not contain strings shorter than {size} symbols.");
    else Console.WriteLine($"\nThis is the resulting array, containing only string(s) smaller or equal to {size} symbols:\n");
    return result;

}

void PrintArray(string[] arr)
{
    int i = 0;
    Console.Write("[");
    for (i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"\"{arr[i]}\", ");
        // Console.Write($"{i}: {arr[i]} ");
    }
    Console.Write($"\"{arr[i]}\"");
    Console.WriteLine("]\n");

    // Console.WriteLine("\n");
}

Console.WriteLine("This is the given array of string elements:\n");
string[] entryArray = { "1234", "1567", "-2", "computer science", "bla", "123" };
PrintArray(entryArray);

Console.WriteLine("Enter the maximum size of strings to put into resulting array: ");
int maxSize = Convert.ToInt32(Console.ReadLine());

PrintArray(ShortStringsOnly(entryArray, maxSize));