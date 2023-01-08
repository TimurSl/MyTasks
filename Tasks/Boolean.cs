namespace Tasks;

public class Boolean
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Boolean1(2));
        Console.WriteLine(Boolean2(10));
        Console.WriteLine(Boolean3(5));
        Console.WriteLine(Boolean4(3, 8));
        Console.WriteLine(Boolean5(5, 23));
        Console.WriteLine(Boolean6(5, 23, 12));
        Console.WriteLine(Boolean7(5, 63, 16));
        Console.WriteLine(Boolean8(5, 63));
        Console.WriteLine(Boolean9(5, 63));
        Console.WriteLine(Boolean10(5, 63));
        Console.WriteLine(Boolean11(5, 63));
        Console.WriteLine(Boolean12(5, 123, 1));
        Console.WriteLine(Boolean13(5, 123, 45));
        Console.WriteLine(Boolean14(5, 187, 45));
        Console.WriteLine(Boolean15(5, 1237, 45));
        Console.WriteLine(Boolean16(125));
        Console.WriteLine(Boolean17(255));
        Console.WriteLine(Boolean18(255, 89, 23));
        Console.WriteLine(Boolean19(587, 124, 387));
        Console.WriteLine(Boolean20(123));
        Console.WriteLine(Boolean21(123));
        Console.WriteLine(Boolean22(123));
        Console.WriteLine(Boolean23(3443));
        Console.WriteLine(Boolean24(3443));
        Console.WriteLine(Boolean25(33, 12));
        Console.WriteLine(Boolean26(33, 12));
        Console.WriteLine(Boolean27(33, 15));
        Console.WriteLine(Boolean28(33, 56));
        Console.WriteLine(Boolean29(33, 56, 23, 45, 23, 47));
        Console.WriteLine(Boolean30(33, 56, 23));
    }

    static bool Boolean1(int a)
    {
        return a > 0;
    }

    static bool Boolean2(int a)
    {
        return a % 2 != 0;
    }
    
    static bool Boolean3(int a)
    {
        return a % 2 == 0;
    }
    
    static bool Boolean4(int a, int b)
    {
        return a > 2 && b <= 3;
    }
    
    static bool Boolean5(int a, int b)
    {
        return a >= 0 || b < -2;
    }
    
    static bool Boolean6(int a, int b, int c)
    {
        return a < b && b < c;
    }
    
    static bool Boolean7(int a, int b, int c)
    {
        return a < b && b < c;
    }
    
    static bool Boolean8(int a, int b)
    {
        return a % 2 != 0 && b % 2 != 0;
    }
    
    static bool Boolean9(int a, int b)
    {
        return a % 2 != 0 || b % 2 != 0;
    }
    
    static bool Boolean10(int a, int b)
    {
        return a % 2 != 0 ^ b % 2 != 0;
    }

    static bool Boolean11(int a, int b)
    {
        return (a % 2 != 0 && b % 2 != 0) || (a % 2 == 0 && b % 2 == 0); 
    }

    static bool Boolean12(int a, int b, int c)
    {
        return a > 0 && b > 0 && c > 0;
    }

    static bool Boolean13(int a, int b, int c)
    {
        return a > 0 || b > 0 || c > 0;
    }
    
    static bool Boolean14(int a, int b, int c)
    {
        return a > 0 ^ b > 0 ^ c > 0;
    }
    
    static bool Boolean15(int a, int b, int c)
    {
        return (a > 0 && b > 0) ^ (a > 0 && c > 0) ^ (b > 0 && c > 0);
    }
    
    static bool Boolean16(int a)
    {
        return a < 100 && a > 9 && a % 2 == 0;
    }

    static bool Boolean17(int a)
    {
        return a < 1000 && a > 99 && a % 2 != 0;
    }
    
    static bool Boolean18(int a, int b, int c)
    {
        return (a == b) || (a == c) || (b == c);
    }
    
    static bool Boolean19(int a, int b, int c)
    {
        return (a > 0 && b < 0) || (a < 0 && b > 0) || (a > 0 && c < 0) || (a < 0 && c > 0) || (b > 0 && c < 0) || (b < 0 && c > 0);
    }

    static bool Boolean20(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a != b && a != c && b != c;
    }

    static bool Boolean21(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a < b && b < c;
    }

    static bool Boolean22(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return (a < b && b < c) || (c < b && b < a);
    }

    static bool Boolean23(int abcd)
    {
        int a = abcd / 1000;
        int b = abcd / 100 % 10;
        int c = abcd / 10 % 10;
        int d = abcd % 10;
        return a == d && b == c;
    }
    
    static bool Boolean24(int abcd)
    {
        int a = abcd / 1000;
        int b = abcd / 100 % 10;
        int c = abcd / 10 % 10;
        int d = abcd % 10;
        return Math.Pow(b, 2) - (4 * a * c) > 0;
    }

    static bool Boolean25(int x, int y)
    {
        return x < 0 && y > 0;
    }

    static bool Boolean26(int x, int y)
    {
        return x > 0 && y < 0;
    }

    static bool Boolean27(int x, int y)
    {
        return (x == 0) || (x < 0 && y < 0);
    }

    static bool Boolean28(int x, int y)
    {
        return x < 0 && y != 0 && y > 0;
    }
    
    static bool Boolean29(int x, int y, int x1, int y1, int x2, int y2)
    {
        return x1 < x && x < x2 && y2 < y && y < y1;
    }

    static bool Boolean30(int a, int b, int c)
    {
        return (a == b) && (c == b) && (c == a);
    }

    static bool Boolean31(int a, int b, int c)
    {
        return (a == b) || (c == b) || (c == a);
    }

    static bool Boolean32(int a, int b, int c)
    {
        return (a == b + c) || (c == b + a) || (b == c + a);
    }

    static bool Boolean33(int a, int b, int c)
    {
        return (a + b) > c && (a + c) > b && (b + c) > a;
    }

    static bool Boolean34(int x, int y)
    {
        return (x + y) % 2 != 0;
    }

    static bool Boolean35(int x1, int y1, int x2, int y2)
    {
        return (x1 + y1) % 2 == (x2 + y2) % 2;
    }

    static bool Boolean36(int x1, int y1, int x2, int y2)
    {
        return (x1 == x2) || (y1 == y2);
    }
    
    static bool Boolean37(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
    }
    
    static bool Boolean38(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1 && (x1 != x2 || y1 != y2);
    }
    
    static bool Boolean39(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1 && (x1 != x2 || y1 != y2) && (x1 + y1) % 2 == (x2 + y2) % 2;
    }
    
    static bool Boolean40(int x1, int y1, int x2, int y2)
    {
        return MathF.Abs(x1 - x2) == 1 && MathF.Abs(y1 - y2) == 2 || MathF.Abs(x1 - x2) == 2 && MathF.Abs(y1 - y2) == 1;
    }
}