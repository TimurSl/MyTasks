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
        Console.WriteLine("[{0}]", string.Join(", ", Integer11(134)));
        Console.WriteLine(Integer12(112));
        Console.WriteLine(Integer13(213));
        Console.WriteLine(Integer14(188));
        Console.WriteLine(Integer15(123));
        Console.WriteLine(Integer16(845));
        Console.WriteLine(Integer17(2022));
        Console.WriteLine(Integer18(1705));
        Console.WriteLine(Integer19(240));
        Console.WriteLine(Integer20(450));
        Console.WriteLine(Integer21(123));
        Console.WriteLine(Integer22(398));
        Console.WriteLine(Integer23(982));
        Console.WriteLine(Integer24(1234));
        Console.WriteLine(Integer25(4652));
        Console.WriteLine(Integer26(987));
        Console.WriteLine(Integer27(872));
        Console.WriteLine(Integer28(123, 3));
        Console.WriteLine(Integer29(123, 3, 23));
        Console.WriteLine(Integer30(2391));
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

        return a % b;;
    }

    static string Integer6(int ab)
    {
        return $"Десятки: {ab / 10}, Единицы: {ab % 10}";
    }

    static string Integer7(int ab)
    {
        int e = ab / 10;
        int c = ab % 10;
        int sum = e + c;
        int multiply = e * c;
        return $"Сумма: {sum}, Произведение: {multiply}";
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

    static int[] Integer11(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return new []{ a + b + c, a * b * c };
    }
    
    static int Integer12(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a * 100 + b * 10 + c;
    }
    
    static int Integer13(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a * 100 + c * 10 + b;
    }
    
    static int Integer14(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return c * 100 + a * 10 + b;
    }
    
    static int Integer15(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return b * 100 + a * 10 + c;
    }
    
    static int Integer16(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return b * 100 + c * 10 + a;
    }
    
    static int Integer17(int abc)
    {
        return (abc % 1000) / 100;
    }
    
    static int Integer18(int abc)
    {
        return (abc % 10000) / 10;
    }

    static int Integer19(int m)
    {
        return m / 60;
    }
    
    static int Integer20(int m)
    {
        return m / 60 / 60;
    }
    
    static int Integer21(int m)
    {
        return m % 60;
    }
    
    static int Integer22(int m)
    {
        return m % 3600;
    }
    
    static int Integer23(int m)
    {
        return m % 3600 / 60;
    }
    
    static int Integer24(int m)
    {
        return m % 7;
    }
    
    static int Integer25(int m)
    {
        return (m + 3) % 7;
    }
    
    static int Integer26(int m)
    {
        return (m % 7) + 1;
    }
    
    static int Integer27(int m)
    {
        return ((m + 4) % 7) + 1;
    }

    static int Integer28(int a, int b)
    {
        return ((a + b - 2) % 7) + 1;
    }

    static int Integer29(int a, int b, int c)
    {
        return (a * b) / (c * c);
    }

    static int Integer30(int abcd)
    {
        return (abcd / 100) + 1;
    }
    
}