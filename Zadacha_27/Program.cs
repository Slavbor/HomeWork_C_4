using static System.Console;
Clear();

WriteLine("Input number: ");

long num = long.Parse(ReadLine()!);

long summary = GetSumNum(num);

WriteLine($"Summary digits of {num}  = {summary}");








long GetSumNum(long a)
{
    long sum = 0;

    while (a != 0)
    {
        long b = a % 10;
        sum += b;
        a /= 10;
    }
    return sum;
}
