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
        If21(53, 54);
        If22(55, 56);
        If23(57, 58, 12, 56, 21, 24);
        If24(59);
        If25(60);
        If26(61);
        If27(62);
        If28(63);
        If29(64);
        If30(65);
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
    static void If21(int x, int y)
    {
        if (x == 0 && y == 0)
        {
            Console.WriteLine(0);
        }
        else if (x == 0)
        {
            Console.WriteLine(1);
        }
        else if (y == 0)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(3);
        }
    }
    
    static void If22(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine(1);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine(2);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine(3);
        }
        else
        {
            Console.WriteLine(4);
        }
    }
    
    static void If23(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        int x4 = 0;
        int y4 = 0;
        if (x1 == x2)
        {
            x4 = x3;
        }
        else if (x1 == x3)
        {
            x4 = x2;
        }
        else
        {
            x4 = x1;
        }
        
        if (y1 == y2)
        {
            y4 = y3;
        }
        else if (y1 == y3)
        {
            y4 = y2;
        }
        else
        {
            y4 = y1;
        }
        
        Console.WriteLine(x4 + " " + y4);
    }
    
    static void If24(float x)
    {
        float result = 0;
        if (x > 0)
        {
            result = 2 * (float)Math.Sin(x);
        }
        else
        {
            result = 6 - x;
        }
        
        Console.WriteLine(result);
    }

    static void If25(float x)
    {
        if (x < -2 || x > 2)
        {
            Console.WriteLine(2 * x);
        }
        else
        {
            Console.WriteLine(-3 * x);
        }
    }
    
    static void If26(float x)
    {
        if (x <= 0)
        {
            Console.WriteLine(-x);
        }
        else if (x > 0 && x < 2)
        {
            Console.WriteLine(x * x);
        }
        else
        {
            Console.WriteLine(4);
        }
    }

    static void If27(float x)
    {
        if (x < 0)
        {
            Console.WriteLine(0);
        }
        else if (x >= 0 && x < 1 || x >= 2 && x < 3)
        {
            Console.WriteLine(1);
        }
        else if(x >= 1 && x < 2 || x >= 3 && x < 4)
        {
            Console.WriteLine(-1);
        }
    }
    
    static void If28(int year)
    {
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine(366);
        }
        else
        {
            Console.WriteLine(365);
        }
    }

    static void If29(int a)
    {
        if (a == 0)
        {
            Console.WriteLine("нулевое число");
        }
        else
        {
            if (a < 0)
            {
                Console.Write("отрицательное ");
            }
            else
            {
                Console.Write("положительное ");
            }
    
            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("нечетное число");
            }
        }
    }
    
    static void If30(int a)
    {
        if (a % 2 == 0)
        {
            Console.Write("четное ");
        }
        else
        {
            Console.Write("нечетное ");
        }
    
        if (a < 10)
        {
            Console.WriteLine("однозначное число");
        }
        else if (a < 100)
        {
            Console.WriteLine("двузначное число");
        }
        else
        {
            Console.WriteLine("трехзначное число");
        }
    }

}