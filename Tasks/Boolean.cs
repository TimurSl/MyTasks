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
    
    
}