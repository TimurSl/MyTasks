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
        return a > b && b < c;
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
}