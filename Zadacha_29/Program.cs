using static System.Console;

Clear();

int[] arr = GetArray(8);

PrintArray(arr);









int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100 + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]}");
        Write(i < arr.Length - 1 ? ", " : "");
    }
}
