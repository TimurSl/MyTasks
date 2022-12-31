namespace Tasks;

public class Integer
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Integer1(1000));
        Console.WriteLine(Integer2(100000));
        Console.WriteLine(Integer3(12325));
        Console.WriteLine(Integer4(123, 23));
        Console.WriteLine(Integer5(23, 12));
        Console.WriteLine(Integer6(43));
        Console.WriteLine(Integer7(92));
        Console.WriteLine(Integer8(75));
        Console.WriteLine(Integer9(123));
        Console.WriteLine(Integer10(246));
        
    }

    static int Integer1(int l)
    {
        return l / 100;
    }

    static int Integer2(int m)
    {
        return m / 1000;
    }

    static int Integer3(int a)
    {
        return a / 1024;
    }

    static int Integer4(int a, int b)
    {
        if (a > b)
        {
            return a / b;
        }

        return 0;
    }

    static int Integer5(int a, int b)
    {
        if (a > b)
        {
            return a % b;
        }

        return 0;
    }

    static string Integer6(int ab)
    {
        if (ab < 100)
        {
            return $"Десятки: {ab / 10}, Единицы: {ab % 10}";
        }
        return $"Числа не двухзначные :(";
    }

    static string Integer7(int ab)
    {
        if (ab < 100)
        {
            int e = ab / 10;
            int c = ab % 10;
            int sum = e + c;
            int multiply = e * c;
            return $"Сумма: {sum}, Произведение: {multiply}";
        }
        return $"Числа не двухзначные :(";
    }

    static int Integer8(int ab)
    {
        int ba = ab / 10 + ab % 10 * 10;
        return ba;
    }

    static int Integer9(int abc)
    {
        return abc / 100;
    }
    
    static string Integer10(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        return $"Сотни: {a}, Десятки: {b}";
    }
    
    
    
    
}
