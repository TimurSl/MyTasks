namespace Tasks;

public class While
{
    public static void Main(string[] args)
    {
        While1(1, 3);
        While2(1, 3);
        While3(1, 3);
        While4(3);
        While5(4);
        While6(5);
        While7(6);
        While8(7);
        While9(8);
        While10(9);
        While11(10);
        While12(11);
        While13(12);
        While14(13);
        While15(14);
        While16(15);
        While17(16);
        While18(17);
        While19(18);
        While20(19);
        
    }

    public static void While1(int a, int b)
    {
        while (a >= b)
        {
            a -= b;
        }
        Console.WriteLine(a);
    }
    
    public static void While2(int a, int b)
    {
        int count = 0;
        while (a >= b)
        {
            a -= b;
            count++;
        }
        Console.WriteLine(count);
    }

    public static void While3(uint n, uint k)
    {   
        int num = 0;
        while (n >= k) {
            n -= k;
            num++;
        }
        Console.WriteLine(num);
    }

    public static void While4(uint a)
    {
        while (a > 0) a -= 3;

        if (a == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    
    public static void While5(uint n)
    {
        int k = 0;
        
        while (n > 1) 
        {
            n /= 2;
            k++;
        }
        
        if (n == 1)
        {
            Console.WriteLine("True");
        } 
        else 
        {
            Console.WriteLine("False");
        }
    }

    public static void While6(int n)
    {
        float result = 1;
        
        while (n >= 2) 
        {
            result *= n;
            n -= 2;
        }

        Console.WriteLine(result);
    }

    public static void While7(int n)
    {
        int k = 1;
        while (k * k <= n) 
        {
            ++k;
        }
        Console.WriteLine(k);
    }

    public static void While8(int n)
    {
        int k = 1;
        
        while (k * k <= n)
        {
            ++k;
        }
        
        Console.WriteLine(k - 1);
    }

    public static void While9(int n)
    {
        int k = 1;
        int temp = 3;
        
        while (temp <= n) 
        {
            temp *= 3;
            ++k;
        }
    }

    public static void While10(int n)
    {
        int k = 0;
        int temp = 3;
        
        while (temp <= n) 
        {
            temp *= 3;
            ++k;
        }
        
        Console.WriteLine(k);
    }
    
    public static void While11(int n)
    {
        int k = 0;
        int sum = 0;
        
        while (sum < n) 
        {
            ++k;
            sum += k;
        }
        
        Console.WriteLine(k);
        Console.WriteLine(sum);
    }

    public static void While12(int n)
    {
        int s = 0; 
        int k = 0;

        while (s <= n)
        {
            s = s + (k + 1);
            k++;
        }

        s = s - (k + 1);
        Console.WriteLine("Наибольшее целое число K равно " + (k - 1));
        Console.WriteLine("Сумма равна " + s);
    }

    public static void While13(int a)
    {
        double k = 1;
        double sum = 0;
        
        while (sum < a)
        {
            sum += 1.0 / k;
            k++;
        }
        Console.WriteLine($"Наименьшеек число K равно {k}");
        Console.WriteLine($"Cумма равна {sum}");
    }

    public static void While14(int a)
    {
        double sum = 0;
        int k = 0;
    
        while(sum < a)
        {
            k++;
            sum = sum + (double) 1 / k;
        }
        Console.WriteLine("Число K становится равным {0}, а сумма равна {1}", k, sum);
    }

    public static void While15(int k)
    {   
        double s = 1000;
        double p = 10;

        while (s <= 1100)
        {
            k++;
            s = s + s * p / 100;
        }
        
        Console.WriteLine($"K = {k}, S = {s}");
    }

    public static void While16(int k)
    {
        double s = 10.0;
        double p = 0.0;

        while (s < 200)
        {
            k = k++;
            s = s * (1 + p / 100.0);
        }

        Console.WriteLine("K  = " + k);
        Console.WriteLine("S = " + Math.Round(s,3));
    }

    public static void While17(int n)
    {
        while (n > 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }
    }

    public static void While18(int n)
    {
        int sum = 0; 
        int count = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
            count++;
        }

        Console.WriteLine($"Количество цифр: {count}"); 
        Console.WriteLine($"Сумма цифр: {sum}");
    }

    public static void While19(int n)
    {
        int result = 0;
        int tenMult = 1;
 
        while (n > 0) 
        {
            int rest = n % 10; 
            result += tenMult * rest; 
            n /= 10; 
            tenMult *= 10;
        }
        Console.WriteLine(result);
    }

    public static void While20(int n)
    {
        bool isTwoInNumber = false;

        while (n > 0)
        {
            int reminder = n % 10;
            if (reminder == 2)
            {
                isTwoInNumber = true;
                break;
            }

            n /= 10;
        }
        Console.WriteLine(isTwoInNumber);
    }

}
