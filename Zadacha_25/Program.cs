using static System.Console;
Clear();

WriteLine("Input numbers: ");

long num1 = long.Parse(ReadLine()!);
long num2 = long.Parse(ReadLine()!);

long pow1 = GetPow(num1,num2);

WriteLine($"{num1} to the power of {num2}  = {pow1}");








long GetPow(long a, long b)
{

    long pow = 1;
    
    for(long i = 1; i <= b; i++)
    {
        pow *= a;
    }
    return pow;

}
