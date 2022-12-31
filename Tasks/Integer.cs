namespace Tasks;

public class Integer
{
    public static void Main(string[] args)
    {
        
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

    static string Integer7(int a, int b)
    {
        if (a < 100 && b < 100)
        {
            int e = a / 10;
            int c = a % 10;
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