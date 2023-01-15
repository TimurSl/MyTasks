namespace Tasks;

public class For
{
    public static void Main(string[] args)
    {
        Console.WriteLine("For1: ");
        For1(10, 2);
        Console.WriteLine("For2: ");
        For2(10, 2);
        Console.WriteLine("For3: ");
        For3(10, 2);
        Console.WriteLine("For4: ");
        For4(14);
        Console.WriteLine("For5: ");
        For5(14);
        Console.WriteLine("For6: ");
        For6(14);
        Console.WriteLine("For7: ");
        For7(14, 15);
        Console.WriteLine("For8: ");
        For8(14, 15);
        Console.WriteLine("For9: ");
        For9(14, 15);
        Console.WriteLine("For10: ");
        For10(17);
    }

    public static void For1(int n, int k)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(k);
        }
    }

    public static void For2(int a, int b)
    { 
        int n = 0;
        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i);
            n++;
        }
        Console.WriteLine(n);
    }

    public static void For3(int a, int b)
    {
        int n = 0;
        for (int i = b - 1; i > a; i--)
        {
            Console.WriteLine(i);
            n++;
        }
        Console.WriteLine(n);
    }

    public static void For4(int a)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * a);
        }
    }

    public static void For5(int a)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine((i * a) / 10);
        }
    }

    public static void For6(int a)
    {
        for (int i = 12; i <= 20; i++)
        {
            Console.WriteLine((i * a) / 10);
        }
    }

    public static void For7(int a, int b)
    {
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    public static void For8(int a, int b)
    {
        int sum = 1;
        for (int i = a; i <= b; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
    
    public static void For9(int a, int b)
    {
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i * i;
        }
        Console.WriteLine(sum);
    }
    
    public static void For10(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }
        Console.WriteLine(sum);
    }

}