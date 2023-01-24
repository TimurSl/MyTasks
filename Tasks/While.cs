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


    
}