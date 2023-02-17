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
        
        Console.WriteLine("---Proc11---");
        X = 2;
        Y = 1;
        Proc11(ref X, ref Y);
        Console.WriteLine($"X = {X}, Y = {Y}");
        
        Console.WriteLine("---Proc12---");
        double A1 = 1;
        double B1 = 2;
        double C1 = 3;
        double A2 = 3;
        double B2 = 2;
        double C2 = 1;
        Proc12(ref A1, ref B1, ref C1, ref A2, ref B2, ref C2);
        Console.WriteLine($"A1 = {A1}, B1 = {B1}, C1 = {C1}, A2 = {A2}, B2 = {B2}, C2 = {C2}");
        
        Console.WriteLine("---Proc13---");
        double X1 = 1;
        double Y1 = 2;
        double X2 = 3;
        double Y2 = 4;
        double X3 = 5;
        double Y3 = 6;
        Proc13(ref X1, ref Y1, ref X2, ref Y2, ref X3, ref Y3);
        Console.WriteLine($"X1 = {X1}, Y1 = {Y1}, X2 = {X2}, Y2 = {Y2}, X3 = {X3}, Y3 = {Y3}");
        
        Console.WriteLine("---Proc14---");
        A = 1;
        B = 2;
        C = 3;
        Proc14(ref A, ref B, ref C);
        Console.WriteLine($"A = {A}, B = {B}, C = {C}");

        Console.WriteLine("---Proc15---");
        A = 1;
        B = 2;
        C = 3;
        Proc15(ref A, ref B, ref C);
        Console.WriteLine($"A = {A}, B = {B}, C = {C}");
        
        Console.WriteLine("---Proc16---");
        X = 1;
        Console.WriteLine(Proc16(X));
        
        Console.WriteLine("---Proc17---");
        A = 1;
        B = 2;
        C = 3;
        Console.WriteLine(Proc17(A, B, C));
        
        Console.WriteLine("---Proc18---");
        double R = 4;
        Console.WriteLine(Proc18(R));
        
        Console.WriteLine("---Proc19---");
        X = 1;
        Y = 2;
        Console.WriteLine(Proc19(X, Y));
        
        Console.WriteLine("---Proc20---");
        A = 1;
        double H = 2;
        Console.WriteLine(Proc20(A, H));
        
        

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
    
    public static void Proc11(ref double X, ref double Y)
    {
        if (X > Y)
        {
            (X, Y) = (Y, X);
        }
    }
    
    public static void Proc12(ref double A1, ref double B1, ref double C1, ref double A2, ref double B2, ref double C2)
    {
        Proc11(ref A1, ref B1);
        Proc11(ref B1, ref C1);
        Proc11(ref A1, ref B1);
        Proc11(ref A2, ref B2);
        Proc11(ref B2, ref C2);
        Proc11(ref A2, ref B2);
    }
    
    public static void Proc13(ref double A1, ref double B1, ref double C1, ref double A2, ref double B2, ref double C2)
    {
        Proc12(ref A1, ref B1, ref C1, ref A2, ref B2, ref C2);
        if (A1 < A2)
        {
            (A1, A2) = (A2, A1);
            (B1, B2) = (B2, B1);
            (C1, C2) = (C2, C1);
        }
        else if (A1 == A2)
        {
            if (B1 < B2)
            {
                (B1, B2) = (B2, B1);
                (C1, C2) = (C2, C1);
            }
            else if (B1 == B2)
            {
                if (C1 < C2)
                {
                    (C1, C2) = (C2, C1);
                }
            }
        }
    }
    
    public static void Proc14(ref double A, ref double B, ref double C)
    {
        (A, B, C) = (C, A, B);
    }
    
    public static void Proc15(ref double A, ref double B, ref double C)
    {
        Proc14(ref A, ref B, ref C);
    }
    
    public static int Proc16(double X)
    {
        if (X < 0)
        {
            return -1;
        }
        else if (X == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    
    public static int Proc17(double A, double B, double C)
    {
        double D = B * B - 4 * A * C;
        if (D < 0)
        {
            return 0;
        }
        else if (D == 0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
    
    public static double Proc18(double R)
    {
        return Math.PI * R * R;
    }
    
    public static double Proc19(double R1, double R2)
    {
        return Proc18(R1) - Proc18(R2);
    }
    
    public static double Proc20(double A, double H)
    {
        double B = Math.Sqrt(A * A / 4 + H * H);
        return A + 2 * B;
    }
}