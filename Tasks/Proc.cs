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
        
        Console.WriteLine("---Proc21---");
        int a1 = 1;
        int b1 = 2;
        Console.WriteLine(Proc21(a1, b1));
        
        
        Console.WriteLine("---Proc22---");
        double a2 = 1;
        double b2 = 2;
        int Op1 = 1;
        Console.WriteLine(Proc22(a2, b2, Op1));
        
        Console.WriteLine("---Proc23---");
        double a3 = 1;
        double b3 = 2;
        int Op2 = 1;
        Console.WriteLine(Proc23(a3, b3));
        
        Console.WriteLine("---Proc24---");
        int a4 = 1;
        Console.WriteLine(Proc24(a4));
        
        Console.WriteLine("---Proc25---");
        int a5 = 1;
        Console.WriteLine(Proc25(a5));
        
        Console.WriteLine("---Proc26---");
        int a6 = 1;
        Console.WriteLine(Proc26(a6));
        
        Console.WriteLine("---Proc27---");
        int a7 = 1;
        int b7 = 2;
        Console.WriteLine(Proc27(a7, new []{ b7 }));
        
        Console.WriteLine("---Proc28---");
        int a8 = 1;
        Console.WriteLine(Proc28(a8));
        
        Console.WriteLine("---Proc29---");
        int a9 = 1;
        Console.WriteLine(Proc29(a9));
        
        Console.WriteLine("---Proc30---");
        int a10 = 1;
        int b10 = 2;
        Console.WriteLine(Proc30(a10, b10));
        
        Console.WriteLine("---Proc31---");
        int a11 = 1;
        Console.WriteLine(Proc31(a11));
        
        Console.WriteLine("---Proc32---");
        int a12 = 1;
        Console.WriteLine(Proc32(a12));
        
        Console.WriteLine("---Proc33---");
        int a13 = 4;
        Console.WriteLine(Proc33(a13));
        
        Console.WriteLine("---Proc34---");
        int a14 = 5;
        Console.WriteLine(Proc34(a14));
        
        Console.WriteLine("---Proc35---");
        int a15 = 6;
        Console.WriteLine(Proc35(a15));
        
        Console.WriteLine("---Proc36---");
        int a16 = 7;
        Console.WriteLine(Proc36(a16));
        
        Console.WriteLine("---Proc37---");
        double a17 = 8;
        double b17 = 9;
        Console.WriteLine(Proc37(a17, b17));
        
        Console.WriteLine("---Proc38---");
        double a18 = 10;
        int b18 = 11;
        Console.WriteLine(Proc38(a18, b18));
        
        Console.WriteLine("---Proc39---");
        double a19 = 12;
        int b19 = 13;
        Console.WriteLine(Proc39(a19, b19));
        
        Console.WriteLine("---Proc40---");
        double a20 = 14;
        int b20 = 15;
        Console.WriteLine(Proc40(a20, b20));
        
        Console.WriteLine("---Proc41---");
        double a21 = 16;
        int b21 = 17;
        Console.WriteLine(Proc41(a21, b21));
        
        Console.WriteLine("---Proc42---");
        double a22 = 18;
        int b22 = 19;
        Console.WriteLine(Proc42(a22, b22));
        
        Console.WriteLine("---Proc43---");
        double a23 = 20;
        int b23 = 21;
        Console.WriteLine(Proc43(a23, b23));
        
        Console.WriteLine("---Proc44---");
        double a24 = 22;
        int b24 = 23;
        Console.WriteLine(Proc44(a24, b24));
        
        Console.WriteLine("---Proc45---");
        double a25 = 24;
        double b25 = 25;
        double c25 = 26;
        Console.WriteLine(Proc45(a25, b25, c25));
        
        Console.WriteLine("---Proc46---");
        int a26 = 27;
        int b26 = 28;
        Console.WriteLine(Proc46(a26, b26));
        
        Console.WriteLine("---Proc47---");
        int a27 = 29;
        int b27 = 30;
        int c27 = 31;
        int d27 = 32;
        Proc47(a27, b27, out c27, out d27);
        Console.WriteLine(c27 + " " + d27);
        
        Console.WriteLine("---Proc48---");
        int a28 = 33;
        int b28 = 34;
        Console.WriteLine(Proc48(a28, b28));
        
        Console.WriteLine("---Proc49---");
        int a29 = 35;
        int b29 = 36;
        int c29 = 37;
        Console.WriteLine(Proc49(a29, b29, c29));
        
        Console.WriteLine("---Proc50---");
        int t30 = 38;
        int h30, m30, s30;
        Proc50(t30, out h30, out m30, out s30);
        Console.WriteLine(h30 + " " + m30 + " " + s30);
        
        Console.WriteLine("---Proc51---");
        int h31 = 39;
        int t31 = 40, m31 = 41, s31 = 42;
        Proc51(H: ref h31, ref m31, ref s31, t31);
        Console.WriteLine(h31 + " " + m31 + " " + s31 + " " + t31);
        
        Console.WriteLine("---Proc52---");
        int a32 = 43;
        Console.WriteLine(Proc52(a32));
        
        Console.WriteLine("---Proc53---");
        int m33 = 44;
        int y33 = 45;
        Console.WriteLine(Proc53(m33, y33));
        
        Console.WriteLine("---Proc54---");
        int d34 = 46;
        int m34 = 47;
        int y34 = 48;
        Proc54(ref d34, ref m34, ref y34);
        Console.WriteLine(d34 + " " + m34 + " " + y34);
        
        Console.WriteLine("---Proc55---");
        Proc55();
        
        Console.WriteLine("---Proc56---");
        double xA36 = 49;
        double yA36 = 50;
        double xB36 = 51;
        double yB36 = 52;
        Console.WriteLine(Proc56(xA36, yA36, xB36, yB36));
        
        Console.WriteLine("---Proc57---");
        double xA37 = 53;
        double yA37 = 54;
        double xB37 = 55;
        double yB37 = 56;
        double xC37 = 57;
        double yC37 = 58;
        Console.WriteLine(Proc57(xA37, yA37, xB37, yB37, xC37, yC37));
        
        Console.WriteLine("---Proc58---");
        double xA38 = 59;
        double yA38 = 60;
        double xB38 = 61;
        double yB38 = 62;
        double xC38 = 63;
        double yC38 = 64;
        Console.WriteLine(Proc58(xA38, yA38, xB38, yB38, xC38, yC38));
        
        Console.WriteLine("---Proc59---");
        double xA39 = 65;
        double yA39 = 66;
        double xB39 = 67;
        double yB39 = 68;
        double xC39 = 69;
        double yC39 = 70;
        Console.WriteLine(Proc59(xA39, yA39, xB39, yB39, xC39, yC39));
        
        Console.WriteLine("---Proc60---");
        double xA40 = 71;
        double yA40 = 72;
        double xB40 = 73;
        double yB40 = 74;
        double xC40 = 75;
        double yC40 = 76;
        double hA40, hB40, hC40;
        Proc60(xA40, yA40, xB40, yB40, xC40, yC40, out hA40, out hB40, out hC40);
        Console.WriteLine(hA40 + " " + hB40 + " " + hC40);
        
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
    
    public static int Proc21(int A, int B)
    {
        int sum = 0;
        if (A > B)
        {
            return 0;
        }
        else
        {
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
    
    public static double Proc22(double A, double B, int Op)
    {
        switch (Op)
        {
            case 1:
                return A - B;
            case 2:
                return A * B;
            case 3:
                return A / B;
            default:
                return A + B;
        }
    }
    
    public static int Proc23(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }
    
    public static bool Proc24(int K)
    {
        return K % 2 == 0;
    }
    
    public static bool Proc25(int K)
    {
        return Math.Sqrt(K) % 1 == 0;
    }
    
    public static bool Proc26(int K)
    {
        while (K > 1)
        {
            if (K % 5 != 0)
            {
                return false;
            }
            K /= 5;
        }
        return true;
    }
    
    public static int Proc27(int N, int[] K)
    {
        int count = 0;
        for (int i = 0; i < K.Length; i++)
        {
            if (Proc26(K[i]))
            {
                count++;
            }
        }
        return count;
    }
    
    public static bool Proc28(int N)
    {
        if (N <= 1)
        {
            return false;
        }
        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static int Proc29(int K)
    {
        int count = 0;
        while (K > 0)
        {
            count++;
            K /= 10;
        }
        return count;
    }
    
    public static int Proc30(int K, int N)
    {
        int count = Proc29(K);
        if (count < N)
        {
            return -1;
        }
        else
        {
            for (int i = 0; i < count - N; i++)
            {
                K /= 10;
            }
            return K % 10;
        }
    }
    
    public static bool Proc31(int K)
    {
        int count = Proc29(K);
        for (int i = 0; i < count / 2; i++)
        {
            if (Proc30(K, i + 1) != Proc30(K, count - i))
            {
                return false;
            }
        }
        return true;
    }
    
    public static double Proc32(double D)
    {
        return D * Math.PI / 180;
    }
    
    public static double Proc33(double R)
    {
        return R * 180 / Math.PI;
    }
    
    public static double Proc34(int N)
    {
        double fact = 1;
        for (int i = 1; i <= N; i++)
        {
            fact *= i;
        }
        return fact;
    }
    
    public static double Proc35(int N)
    {
        double fact = 1;
        for (int i = 2; i <= N; i += 2)
        {
            fact *= i;
        }
        return fact;
    }
    
    public static int Proc36(int N)
    {
        if (N == 1 || N == 2)
        {
            return 1;
        }
        else
        {
            return Proc36(N - 1) + Proc36(N - 2);
        }
    }
    public static double Proc37(double A, double B)
    {
        if (A <= 0)
        {
            return 0;
        }
        else
        {
            return Math.Exp(B * Math.Log(A));
        }
    }
    
    public static double Proc38(double A, int N)
    {
        if (N == 0)
        {
            return 1;
        }
        else if (N > 0)
        {
            double result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= A;
            }
            return result;
        }
        else
        {
            double result = 1;
            for (int i = 0; i < -N; i++)
            {
                result *= A;
            }
            return 1 / result;
        }
    }
    
    public static double Proc39(double A, double B)
    {
        if (B % 1 == 0)
        {
            return Proc38(A, (int)B);
        }
        else
        {
            return Proc37(A, B);
        }
    }
    
    public static double Proc40(double x, double e)
    {
        double result = 1;
        double summand = 1;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            summand *= x / n;
            result += summand;
            n++;
        }
        return result;
    }
    
    public static double Proc41(double x, double e)
    {
        double result = 0;
        double summand = x;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            result += summand;
            summand *= -x * x / (2 * n * (2 * n + 1));
            n++;
        }
        return result;
    }
    
    public static double Proc42(double x, double e)
    {
        double result = 1;
        double summand = 1;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            summand *= -x * x / (2 * n * (2 * n - 1));
            result += summand;
            n++;
        }
        return result;
    }
    
    public static double Proc43(double x, double e)
    {
        double result = 0;
        double summand = x;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            result += summand;
            summand *= -x / (n + 1);
            n++;
        }
        return result;
    }
    
    public static double Proc44(double x, double e)
    {
        double result = 0;
        double summand = x;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            result += summand;
            summand *= -x * x / (2 * n * (2 * n - 1));
            n++;
        }
        return result;
    }
    
    public static double Proc45(double x, double a, double e)
    {
        double result = 1;
        double summand = 1;
        int n = 1;
        while (Math.Abs(summand) > e)
        {
            summand *= a * x / n;
            result += summand;
            n++;
        }
        return result;
    }
    
    public static int Proc46(int A, int B)
    {
        if (B == 0)
        {
            return A;
        }
        else
        {
            return Proc46(B, A % B);
        }
    }
    
    public static void Proc47(int A, int B, out int P, out int Q)
    {
        int nod = Proc46(A, B);
        P = A / nod;
        Q = B / nod;
    }
    
    public static int Proc48(int A, int B)
    {
        return A * B / Proc46(A, B);
    }
    
    public static int Proc49(int A, int B, int C)
    {
        return Proc46(Proc46(A, B), C);
    }
    
    public static void Proc50(int T, out int H, out int M, out int S)
    {
        H = T / 3600;
        M = (T - H * 3600) / 60;
        S = T - H * 3600 - M * 60;
    }
    
    public static void Proc51(ref int H, ref int M, ref int S, int T)
    {
        int time = H * 3600 + M * 60 + S + T;
        Proc50(time, out H, out M, out S);
    }
    
    public static bool Proc52(int Y)
    {
        if (Y % 4 == 0 && Y % 100 != 0 || Y % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static int Proc53(int M, int Y)
    {
        if (M == 2)
        {
            if (Proc52(Y))
            {
                return 29;
            }
            else
            {
                return 28;
            }
        }
        else if (M == 4 || M == 6 || M == 9 || M == 11)
        {
            return 30;
        }
        else
        {
            return 31;
        }
    }
    
    public static void Proc54(ref int D, ref int M, ref int Y)
    {
        if (D == 1)
        {
            if (M == 1)
            {
                D = 31;
                M = 12;
                Y--;
            }
            else
            {
                D = Proc53(M - 1, Y);
                M--;
            }
        }
        else
        {
            D--;
        }
    }
    
    public static void Proc55()
    {
        int D = 1;
        int M = 1;
        int Y = 1;
        Proc54(ref D, ref M, ref Y);
        Console.WriteLine($"{D}.{M}.{Y}");
    }
    
    public static double Proc56(double xA, double yA, double xB, double yB)
    {
        return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    }
    
    public static double Proc57(double xA, double yA, double xB, double yB, double xC, double yC)
    {
        return Proc56(xA, yA, xB, yB) + Proc56(xB, yB, xC, yC) + Proc56(xC, yC, xA, yA);
    }
    
    public static double Proc58(double xA, double yA, double xB, double yB, double xC, double yC)
    {
        double p = Proc57(xA, yA, xB, yB, xC, yC) / 2;
        return Math.Sqrt(p * (p - Proc56(xA, yA, xB, yB)) * (p - Proc56(xA, yA, xC, yC)) * (p - Proc56(xB, yB, xC, yC)));
    }
    
    public static double Proc59(double xP, double yP, double xA, double yA, double xB, double yB)
    {
        return 2 * Proc58(xP, yP, xA, yA, xB, yB) / Proc56(xA, yA, xB, yB);
    }
    
    public static void Proc60(double xA, double yA, double xB, double yB, double xC, double yC, out double hA, out double hB, out double hC)
    {
        hA = Proc59(xA, yA, xB, yB, xC, yC);
        hB = Proc59(xB, yB, xA, yA, xC, yC);
        hC = Proc59(xC, yC, xA, yA, xB, yB);
    }

}