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

    public static void Series11(int n, int k, int[] numbers)
    {
        bool status = false;
        for (int i = n; i <= n; i++)
        {
            if (numbers[i] < k)
            {
                status = true;
            }
        }

        Console.WriteLine(status);
    }

    public static void Series12(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
    
    public static void Series13(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] > 0 && numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
        }

        Console.WriteLine(sum);
    }
    
    public static void Series14(int[] numbers, int k)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] < k)
            {
                count++;
            }
            
        }

        Console.WriteLine(count);
    }
    
    public static void Series15(int[] numbers, int k)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] > k)
            {
                count = i;
                break;
            }
            
        }

        Console.WriteLine(count);
    }
    
    public static void Series16(int[] numbers, int k)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] > k)
            {
                count = i;
            }
            
        }

        Console.WriteLine(count);
    }
    
    public static void Series17(float[] numbers, float b)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] > b)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers[i]);
            }
            else
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
    
    public static void Series18(int[] numbers, int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] != numbers[i + 1])
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
    
    public static void Series19(int[] numbers, int n)
    {
        int count = 0;
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] < numbers[i - 1])
            {
                Console.WriteLine(numbers[i]);
                count++;
            }
        }

        Console.WriteLine(count);
    }
    
    public static void Series20(int[] numbers, int n)
    {
        int count = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] < numbers[i + 1])
            {
                Console.WriteLine(numbers[i]);
                count++;
            }
        }

        Console.WriteLine(count);
    }

    public static void Series21(int n, float[] numbers)
    {
        bool status = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                status = true;
            }
            else
            {
                status = false;
                break;
            }
        }

        Console.WriteLine(status);
    }

    public static void Series22(int n, float[] numbers)
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                Console.WriteLine(i + 1);
                break;
            }
            else if (numbers[i] < numbers[i + 1])
            {
                Console.WriteLine(0);
                break;
            }
        }
    }

    public static void Series23(int n, float[] numbers)
    {
        for (int i = 1; i < n - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] > numbers[i - 1] && numbers[i] < numbers[i + 1])
            {
                Console.WriteLine(0);
                break;
            }
            else if (numbers[i] < numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                Console.WriteLine(0);
                break;
            }
        }
    }

    public static void Series24(int n, int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] == 0 && numbers[i + 1] == 0)
            {
                Console.WriteLine(0);
                break;
            }
            else if (numbers[i] == 0)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] == 0)
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                    else
                    {
                        sum += numbers[j];
                    }
                }
            }
        }
    }

    public static void Series25(int n, int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] == 0 && numbers[i + 1] == 0)
            {
                Console.WriteLine(0);
                break;
            }
            else if (numbers[i] == 0)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] == 0)
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                    else
                    {
                        sum += numbers[j];
                    }
                }
            }
        }
    }
    
    public static void Series26(int n, int k, float[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j < k; j++)
            {
                result *= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
    
    public static void Series27(int n, float[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j < i + 1; j++)
            {
                result *= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
    
    public static void Series28(int n, float[] numbers)
    {
        for (int i = 0; i < n; i++)
        {
            float result = 1;
            for (int j = 0; j < n - i; j++)
            {
                result *= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
    
    public static void Series29(int n, int k, int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < n * k; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine(sum);
    }
    
    public static void Series30(int n, int k, int[] numbers)
    {
        for (int i = 0; i < n * k; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}