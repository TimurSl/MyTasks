namespace Tasks;

public class Proc
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---Proc1---");
        double A = 2;
        double B;
        Proc1(A, out B);
        Console.WriteLine($"A = {A}, B = {B}");
        
        Console.WriteLine("---Proc2---");
        double C;
        double D;
        Proc2(A, out B, out C, out D);
        Console.WriteLine($"A = {A}, B = {B}, C = {C}, D = {D}");
        
        Console.WriteLine("---Proc3---");
        double AMean;
        double GMean;
        Proc3(A, B, C, D, out AMean, out GMean);
        Console.WriteLine($"A = {A}, B = {B}, C = {C}, D = {D}, AMean = {AMean}, GMean = {GMean}");
        
        Console.WriteLine("---Proc4---");
        double P;
        double S;
        Proc4(A, out P, out S);
        Console.WriteLine($"A = {A}, P = {P}, S = {S}");
        
        Console.WriteLine("---Proc5---");
        double x1 = 1;
        double y1 = 2;
        double x2 = 3;
        double y2 = 4;
        Proc5(x1, y1, x2, y2, out P, out S);
        Console.WriteLine($"x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}, P = {P}, S = {S}");
        
        Console.WriteLine("---Proc6---");
        int K = 12345;
        int i_c;
        int i_s;
        Proc6(K, out i_c, out i_s);
        Console.WriteLine($"K = {K}, C = {i_c}, S = {i_s}");
        
        Console.WriteLine("---Proc7---");
        Proc7(ref K);
        Console.WriteLine($"K = {K}");
        
        Console.WriteLine("---Proc8---");
        K = 0;
        Proc8(1, ref K);
        Proc8(2, ref K);
        Proc8(3, ref K);
        Console.WriteLine($"K = {K}");
        
        Console.WriteLine("---Proc9---");
        K = 0;
        Proc9(1, 2, ref K);
        Proc9(3, 4, ref K);
        Console.WriteLine($"K = {K}");
        
        Console.WriteLine("---Proc10---");
        double X = 1;
        double Y = 2;
        Proc10(ref X, ref Y);
        Console.WriteLine($"X = {X}, Y = {Y}");
        

    }
    
    public static void Proc1(double A, out double B)
    {
        B = A * A * A;
    }
    
    public static void Proc2(double A, out double B, out double C, out double D)
    {
        B = A * A;
        C = B * A;
        D = C * A;
    }
    
    public static void Proc3(double A, double B, double C, double D, out double AMean, out double GMean)
    {
        AMean = (A + B) / 2;
        GMean = Math.Sqrt(A * B);
    }
    
    public static void Proc4(double a, out double P, out double S)
    {
        P = 3 * a;
        S = a * a * Math.Sqrt(3) / 4;
    }
    
    public static void Proc5(double x1, double y1, double x2, double y2, out double P, out double S)
    {
        P = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
        S = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
    }
    
    public static void Proc6(int K, out int C, out int S)
    {
        C = 0;
        S = 0;
        while (K > 0)
        {
            C++;
            S += K % 10;
            K /= 10;
        }
    }
    
    public static void Proc7(ref int K)
    {
        int temp = 0;
        while (K > 0)
        {
            temp = temp * 10 + K % 10;
            K /= 10;
        }
        K = temp;
    }
    
    public static void Proc8(int D, ref int K)
    {
        K = K * 10 + D;
    }
    
    public static void Proc9(int D1, int D2, ref int K)
    {
        Proc8(D1, ref K);
        Proc8(D2, ref K);
    }
    
    public static void Proc10(ref double X, ref double Y)
    {
        (X, Y) = (Y, X);
    }
}