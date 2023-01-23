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
        Console.WriteLine("For11: ");
        For11(17);
        Console.WriteLine("For12: ");
        For12(17);
        Console.WriteLine("For13: ");
        For13(17);
        Console.WriteLine("For14: ");
        For14(17);
        Console.WriteLine("For15: ");
        For15(17, 12);
        Console.WriteLine("For16: ");
        For16(17, 12);
        Console.WriteLine("For17: ");
        For17(17, 12);
        Console.WriteLine("For18: ");
        For18(17, 12);
        Console.WriteLine("For19: ");
        For19(17);
        Console.WriteLine("For20: ");
        For20(17);
        Console.WriteLine("For21: ");
        For21(3);
        Console.WriteLine("For22: ");
        For22(17, 12);
        Console.WriteLine("For23: ");
        For23(17, 12);
        Console.WriteLine("For24: ");
        For24(17, 12);
        Console.WriteLine("For25: ");
        For25(17, 12);
        Console.WriteLine("For26: ");
        For26(17, 12);
        Console.WriteLine("For27: ");
        For27(17, 12);
        Console.WriteLine("For28: ");
        For28(17, 12);
        Console.WriteLine("For29: ");
        For29(17, 12, 23);
        Console.WriteLine("For30: ");
        For30(17, 12, 23);
        Console.WriteLine("For31: ");
        For31(17);
        Console.WriteLine("For32: ");
        For32(17);
        Console.WriteLine("For33: ");
        For33(17);
        Console.WriteLine("For34: ");
        For34(17);
        Console.WriteLine("For35: ");
        For35(17);
        Console.WriteLine("For36: ");
        For36(17, 12);
        Console.WriteLine("For37: ");
        For37(17);
        Console.WriteLine("For38: ");
        For38(17);
        Console.WriteLine("For39: ");
        For39(11, 156);
        Console.WriteLine("For40: ");
        For40(17, 22);
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
    public static void For11(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (i * i) + ((i + 1) * (i + 1));
        }
        Console.WriteLine(sum);
    }
    
    public static void For12(int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= (1 + 1.0 / i);
        }
        Console.WriteLine(sum);
    }
    
    public static void For13(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (1.0 / i) * Math.Pow(-1, i);
        }
        Console.WriteLine(sum);
    }
    
    public static void For14(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (2 * i - 1);
            Console.WriteLine(sum);
        }
        Console.WriteLine(sum);
    }
    
    public static void For15(double a, int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= a;
        }
        Console.WriteLine(sum);
    }
    
    public static void For16(double a, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(Math.Pow(a, i));
        }
    }
    
    public static void For17(double a, int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(a, i);
        }
        Console.WriteLine(sum);
    }
    
    public static void For18(double a, int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(-1, i) * Math.Pow(a, i);
        }
        Console.WriteLine(sum);
    }
    
    public static void For19(int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
    
    public static void For20(int n)
    {
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += Factorial(i);
        }
        Console.WriteLine(sum);
    }
    
    static int Factorial(int n)
    {
        if (n == 1 || n == 0) return 1;
        
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void For21(int n)
    {
        int sum = 1;
        for (int i = 0; i < n; i++)
        {
            sum += 1 / Factorial(i);
        }
        Console.WriteLine(sum);
    }

    public static void For22(double x, int n)
    {
        double sum = 1 + x;
        for (int i = 0; i < x; i++)
        {
            sum += Math.Pow(x, n) / (Factorial(n));
        }
        Console.WriteLine(sum);
    }
    
    public static void For23(int x, int n)
    {
        double s = x;
        int k = 1;
        for (int i = 0; i < n + 1; i++)
        {
            k *= (2 * i + 1);
            s += (Math.Pow(-1, i) * Math.Pow(x, (2 * i + 1))) / k;
        }
        Console.WriteLine(s);
        Console.WriteLine(Math.Sin(x));
    }

    public static void For24(float x, int n)
    {
        float x1 = 1;
        float n1 = 1; 
        float rez = 1.0f;
        int i, k = 0;
 
        for (i = 2; i <= n; ++i) {
            ++k;
            n1 *= (float)k;
            ++k;
            n1 *= (float)k;
            x1 *= -1 * x * x;
            rez += x1 / n1;
        }
        Console.WriteLine(rez);
        Console.WriteLine(Math.Cos(x));
    }

    public static void For25(float x, int n)
    {
        float x1 = x;
        float rez = x;
        int i;
 
        for (i = 2; i <= n; ++i) {  
            x1 *= -1 * x;
            rez += x1 / i;
        }
        Console.WriteLine(rez);
        Console.WriteLine(Math.Log(1 + x));
    }
    
    public static void For26(float x, int n)
    {
        float x1 = x;
        float rez = x;
        int i, k = 1;
        
        for (i = 2; i <= n; ++i) {
            k += 2;
            x1 *= -1 * x * x;
            rez += x1 / k;
        }
        
        Console.WriteLine(rez);
        Console.WriteLine(Math.Atan(x));
    }
    
    public static void For27(float x, int n)
    {
        float otvet;
        float b;
        float c;
        float pow;
        
        b = pow = 1;
        c = x;
        otvet = x;
        
        for(int i = 1; i <= n; i++)
        {
            c = c * x * x;
            pow = pow * (2 * i - 1);
            b = b * (i * 2 + 1) * (i * 2);
            otvet += (pow * c) / b;
            b = b / (i * 2 + 1);
        }
        
        Console.WriteLine(otvet);
        Console.WriteLine(Math.Asin(x));
    }

    public static void For28(float x, int n)
    {
        float tempVar1 = 1;
        float tempVar2 = 1;
        float result = 1; 
        float pow = 1;
        
        for (int i = 1; i < n; ++i) 
        {
            tempVar1 *= 2 * i - 3;
            tempVar2 *= 2 * i;
            pow *= (-1) * x;
            result += tempVar1 * pow / tempVar2;
        }

        Console.WriteLine(result);
        Console.WriteLine(Math.Asin(x));
    }

    public static void For29(int n, float a, float b)
    {
        float h = (b - a) / n;
        Console.WriteLine(h);

        for (int i = 0; i <= n; ++i)
        {
            Console.WriteLine(a + i * h);
        }
    }

    public static void For30(int n, float a, float b)
    {
        float h = (b - a) / n;
        Console.WriteLine(h);
        
        for (int i = 0; i <= n; ++i) 
        {
            Console.WriteLine(1 - MathF.Sin(a + i * h));
        }
    }
        
    public static void For31(int n)
    {
        float a = 2;
        Console.WriteLine(a);
        for (int i = 1; i < n; i++)
        {
            a = 2 + 1 / a;
            Console.WriteLine(a);
        }
    }
    
    public static void For32(int n)
    {
        float a = 1;
        Console.WriteLine(a);
        for (int i = 1; i < n; i++)
        {
            a = (a + 1) / i;
            Console.WriteLine(a);
        }
    }
    
    public static void For33(int n)
    {
        int a = 1;
        int b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
    }
    
    public static void For34(int n)
    {
        float a = 1;
        float b = 2;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 2; i < n; i++)
        {
            float c = (a + 2 * b) / 3;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
    }
    
    public static void For35(int n)
    {
        int a1 = 1;
        int a2 = 2;
        int a3 = 3;
        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(a3);
        for (int i = 3; i < n; i++)
        {
            int a = a3 + a2 - 2 * a1;
            a1 = a2;
            a2 = a3;
            a3 = a;
            Console.WriteLine(a);
        }
    }
    public static void For36(int n, int k)
    {
        float sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (float)1 / (i * i + k);
        }
        Console.WriteLine(sum);
    }
    
    public static void For37(int n)
    {
        float sum = 0;
        for (int i = 1; i <= n; i++)
        {
            float temp = 1;
            for (int j = 1; j <= i; j++)
            {
                temp *= j;
            }
            sum += temp;
        }
        Console.WriteLine(sum);
    }
    
    public static void For38(int n)
    {
        float sum = 0;
        for (int i = 1; i <= n; i++)
        {
            float temp = 1;
            for (int j = 1; j <= i; j++)
            {
                temp *= j;
            }
            sum += temp;
        }
        Console.WriteLine(sum);
    }
    
    public static void For39(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    public static void For40(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i - a + 1; j++)
            {
                Console.WriteLine(i);
            }
        }
    }
}