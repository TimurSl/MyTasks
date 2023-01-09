namespace Tasks;

public class If
{
    public static void Main(string[] args)
    {
        If1(4);
        If2(5);
        If3(6);
        If4(7, 8, 9);
        If5(10, 11, 12);
        If6(13, 14);
        If7(15, 16);
        If8(17, 18);
        If9(19, 20);
        If10(21, 22);
    }

    static void If1(int a)
    {
        if (a > 0)
        {
            a += 1;
        }
        // решил сделать без return
        Console.WriteLine(a);
    }

    static void If2(int a)
    {
        if (a > 0)
        {
            a += 1;
        }
        else
        {
            a -= 2;
        }

        Console.WriteLine(a);
    }

    static void If3(int a)
    {
        if (a > 0)
        {
            a += 1;
        }
        else if (a < 0)
        {
            a -= 2;
        }
        else
        {
            a = 10;
        }

        Console.WriteLine(a);
    }
    
    static void If4(int a, int b, int c)
    {
        int positive = 0;

        if (a > 0)
        {
            positive += 1;
        }

        if (b > 0)
        {
            positive += 1;
        }

        if (c > 0)
        {
            positive += 1;
        }

        Console.WriteLine($"Positive: {positive}");
    }
    
    static void If5(int a, int b, int c)
    {
        int positive = 0;
        int negative = 0;
        if (a > 0)
        {
            positive += 1;
        }
        else
        {
            negative += 1;
        }
        
        if (b > 0)
        {
            positive += 1;
        }
        else
        {
            negative += 1;
        }
        
        if (c > 0)
        {
            positive += 1;
        }
        else
        {
            negative += 1;
        }

        Console.WriteLine($"Positive: {positive}, Negative: {negative}");
    }

    static void If6(int a, int b)
    {
        // Console.WriteLine(Math.Max(a, b)); // Первое решение
        // Console.WriteLine(a > b ? a : b); // Второе решение
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }

    static void If7(int a, int b)
    {
        Console.WriteLine(a > b ? 1 : 2);
    }
    
    static void If8(int a, int b)
    {
        string result = String.Empty;
        if (a > b)
        {
            result += a + " " + b;
        }
        else
        {
            result += b + " " + a;
        }

        Console.WriteLine(result);
    }

    static void If9(int a, int b)
    {
        if (a < b)
        {
            (a, b) = (b, a);
        }
        
        Console.WriteLine(a + " " + b);
    }

    static void If10(int a, int b)
    {
        if (a != b)
        {
            int sum = a + b;
            a = sum;
            b = sum;
        }
        else
        {
            a = 0;
            b = 0;
        }
        
        Console.WriteLine(a + " " + b);
    }
}