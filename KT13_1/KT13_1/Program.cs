namespace KT13_1;

class Program
{
    public static T Max<T>(T x, T y) where T: IComparable<T>
    {
        if (x.CompareTo(y) >= 0)
        {
            return x;
        }
        else
        {
            return y;
        }

    }
    static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine($"Max(int): {Max(a, b)}");

        string s1 = "apple", s2 = "banana";
        Console.WriteLine($"Max(string): {Max(s1, s2)}");

        DateTime d1 = new DateTime(2025, 12, 1);
        DateTime d2 = new DateTime(2025, 11, 25);
        Console.WriteLine($"Max(DateTime): {Max(d1, d2)}");
    }
}

