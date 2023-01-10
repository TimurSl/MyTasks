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
        If11(23, 24);
        If12(25, 26, 27);
        If13(28, 29, 30);
        If14(31, 32, 33);
        If15(34, 35, 36);
        If16(37, 38, 39);
        If17(40, 41, 42);
        If18(43, 44, 45);
        If19(46, 47, 48, 49);
        If20(50, 51, 52);
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

    static void If11(int a, int b)
    {
        int max = Math.Max(a, b);
        if (a == b)
        {
            a = max;
            b = max;
        }
        else
        {
            a = 0;
            b = 0;
        }
        
        Console.WriteLine(a + " " + b);
    }

    static void If12(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }

    static void If13(int a, int b, int c)
    {
        if (a > b && a < c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b < c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }

    static void If14(int a, int b, int c)
    {
        string result = String.Empty;
        if (a < b && a < c)
        {
            result += a + " ";
        }
        else if (b < a && b < c)
        {
            result += b + " ";
        }
        else
        {
            result += c + " ";
        }

        if (a > b && a > c)
        {
            result += a;
        }
        else if (b > a && b > c)
        {
            result += b;
        }
        else
        {
            result += c;
        }
        
        Console.WriteLine(result);
    }

    static void If15(int a, int b, int c)
    {
        int result = 0;
        // Найти сумму из двух наибольщих чисел
        if (a > b && a > c)
        {
            result = a + Math.Max(b, c);
        }
        else if (b > a && b > c)
        {
            result = b + Math.Max(a, c);
        }
        else
        {
            result = c + Math.Max(a, b);
        }
    }

    static void If16(float a, float b, float c)
    {
        if (a < b && b < c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a = -a;
            b = -b;
            c = -c;
        }
        
        Console.WriteLine(a + " " + b + " " + c);
    }
    
    static void If17(float a, float b, float c)
    {
        if (a < b && b < c || a > b && b > c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else
        {
            a = -a;
            b = -b;
            c = -c;
        }
        
        Console.WriteLine(a + " " + b + " " + c);
    }
    
    static void If18(int a, int b, int c)
    {
        if (a == b)
        {
            Console.WriteLine(3);
        }
        else if (a == c)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
    
    static void If19(int a, int b, int c, int d)
    {
        if (a == b && a == c)
        {
            Console.WriteLine(4);
        }
        else if (a == b && a == d)
        {
            Console.WriteLine(3);
        }
        else if (a == c && a == d)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
    
    static void If20(int a, int b, int c)
    {
        int distanceB = Math.Abs(a - b);
        int distanceC = Math.Abs(a - c);
        if (distanceB < distanceC)
        {
            Console.WriteLine("B " + distanceB);
        }
        else
        {
            Console.WriteLine("C " + distanceC);
        }
    }
    
}