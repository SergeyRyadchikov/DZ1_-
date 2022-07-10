Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;

if (N > 0)
{
    while (result <= N)
    {
        if (result % 2 == 0)
        {
            Console.Write(result);
            result++;
        }
        else
        {
            result++;
        }
    }
}

else
{
    result = -1;
    while (result >= N)
    {
       if (result % 2 == 0)
        {
            Console.Write(result);
            result--;
        }
        else
        {
            result--;
        }
    }
}