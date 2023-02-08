namespace Tasks;

public class Series
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---Series 1:");
        Series1(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
        Console.WriteLine("---Series 2:");
        Series2(new []{ 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f});
        Console.WriteLine("---Series 3:");
        Series3(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
        Console.WriteLine("---Series 4:");
        Series4(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
        Console.WriteLine("---Series 5:");
        Series5(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9f});
        Console.WriteLine("---Series 6:");
        Series6(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9f});
        Console.WriteLine("---Series 7:");
        Series7(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9f});
        Console.WriteLine("---Series 8:");
        Series8(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
        Console.WriteLine("---Series 9:");
        Series9(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
        Console.WriteLine("---Series 10:");
        Series10(4, new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9});
    }

    public static void Series1(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }

    public static void Series2(float[] numbers)
    {
        float sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
    
    public static void Series3(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum / numbers.Length);
    }
    
    public static void Series4(int n, int[] numbers)
    {
        double sum = 0;
        double pro = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += numbers[i];
            pro *= numbers[i];
        }
        
        Console.WriteLine("Сумма: {0}", sum);
        Console.WriteLine("Произведение: {0}", pro);
    }

    public static void Series5(int N, float[] numbers)
    {
        float sum = 0;
        for (int i = 0; i < N; i++)
        {
            numbers[i] = MathF.Round(numbers[i], 0);
            sum += numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine(sum);
    }

    public static void Series6(int N, float[] numbers)
    {
        float sum = 0;
        for (int i = 0; i < N; i++)
        {
            numbers[i] = numbers[i] - MathF.Round(numbers[i], 0);
            sum *= numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine(sum);
    }

    public static void Series7(int N, float[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            numbers[i] = MathF.Round(numbers[i], 0);
            sum += int.Parse(numbers[i].ToString());
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine(sum);
    }

    public static void Series8(int N, int[] numbers)
    {
        int K = 0;
        for (int i = 0; i < N; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                K++;
                Console.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine(K);
    }
    
    public static void Series9(int N, int[] numbers)
    {
        int K = 0;
        for (int i = 0; i < N; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                K++;
                Console.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine(K);
    }
    
    public static void Series10(int N, int[] numbers)
    {
        bool positive = false;
        for (int i = 0; i < N; i++)
        {
            if (numbers[i] > 0)
            {
                positive = true;
                Console.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine(positive);
    }

    
}