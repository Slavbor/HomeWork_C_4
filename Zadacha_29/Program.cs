using static System.Console;
Clear();



PrintArray(GetArray(8, 0, 100));




 int[] GetArray(int size, int RandomFrom, int RandomTo)
 {
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(RandomFrom, RandomTo + 1);
    }
    return array;
 }


void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Write ($"{arr[i]}, ");
    }
    WriteLine();
}