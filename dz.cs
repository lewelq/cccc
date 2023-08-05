//1
/*using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Четные числа от 1 до {0}: {1}", n, GetEvenNumbers(2, n));
    }
    static string GetEvenNumbers(int current, int max)
    {
        if (current > max)
        {
            return "";
        }
        else if (current % 2 == 0)
        {
            return current + ", " + GetEvenNumbers(current + 2, max);
        }
        else
        {
            return GetEvenNumbers(current + 1, max);
        }
    }
}*/
//2
/*using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", m, n, GetSum(m, n));
    }

    static int GetSum(int current, int max)
    {
        if (current > max)
        {
            return 0;
        }
        else
        {
            return current + GetSum(current + 1, max);
        }
    }
}*/
//3
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("M={0}, N={1}: {2}", m, n, Ackermann(m, n));
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}