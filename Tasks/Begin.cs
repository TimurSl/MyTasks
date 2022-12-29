using System.Numerics;

namespace Tasks;

public class Begin
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Begin1(4));
        Console.WriteLine(Begin2(3));
        Console.WriteLine(Begin3(3, 7));
        Console.WriteLine(Begin4(4));
        Console.WriteLine(Begin5(2));
        Console.WriteLine(Begin6(4, 3, 5));
        Console.WriteLine(Begin7(7.40f));
        Console.WriteLine(Begin8(9, 3));
        Console.WriteLine(Begin9(3, 5));
        Console.WriteLine(Begin10(7, 12));
        Console.WriteLine(Begin11(1.5f, 12f));
        Console.WriteLine(Begin12(25, 53));
        Console.WriteLine(Begin13(42, 23));
        Console.WriteLine(Begin14(8));
        Console.WriteLine(Begin15(90));
        Console.WriteLine(Begin16(12, 4));
        Console.WriteLine(Begin17(28, 20, 9));
        Console.WriteLine(Begin18(15, 20, 10));
        Console.WriteLine(Begin19(10, 5, 20, 10));
        Console.WriteLine(Begin20(1, 2, 3, 4));
        Console.WriteLine(Begin21(0, 0, 5, 5, 10, 0));
        Console.WriteLine(Begin22("1", "4"));
        Console.WriteLine(Begin23("a", "b", "c"));
        Console.WriteLine(Begin24("a", "b", "c"));
        Console.WriteLine(Begin25(4));
        Console.WriteLine(Begin26(7));
        Console.WriteLine(Begin27(2));
        Console.WriteLine(Begin28(5));
        Console.WriteLine(Begin29(175));
        Console.WriteLine(Begin30(2));
    }
    
    static float Begin1(float a)
    {
        return a * 4;
    }

    static float Begin2(float a)
    {
        return MathF.Pow(a, 2);
    }

    static string Begin3(float a, float b)
    {
        float area = a * b;
        float perimeter = 2 * (a + b);

        return $"Area: {area}, Perimeter: {perimeter}";
    }

    static float Begin4(float d)
    {
        return MathF.PI * d;
    }

    static string Begin5(float a)
    {
        float volume = MathF.Pow(a, 3);
        float area = 6 * MathF.Pow(a, 2);

        return $"Volume: {volume}, Area: {area}";
    }

    static string Begin6(float a, float b, float c)
    {
        float volume = a * b * c;
        float area = 2 * (a * b + b * c + a * c);

        return $"Volume: {volume}, Area: {area}";
    }

    static string Begin7(float R)
    {
        float length = 2 * MathF.PI * R;
        float area = MathF.PI * MathF.Pow(R, 2);

        return $"Length: {length}, Area: {area}";
    }

    static float Begin8(float a, float b)
    {
        return (a + b) / 2;
    }

    static float Begin9(float a, float b)
    {
        return MathF.Sqrt(a * b);
    }

    static string Begin10(float a, float b)
    {
        float s_a = MathF.Sqrt(a);
        float s_b = MathF.Sqrt(b);
        
        float sum = s_a + s_b;
        float difference = MathF.Max(s_a, s_b) - MathF.Min(s_a, s_b);
        float multiply = s_a * s_b;
        float quotient = s_a / s_b;

        return $"Sum: {sum}, Difference: {difference}, Multiply: {multiply}, Quotient: {quotient}";
    }

    static string Begin11(float a, float b)
    {
        float moduleA = MathF.Abs(a);
        float moduleB = MathF.Abs(b);

        float sum = moduleA + moduleB;
        float difference = MathF.Max(moduleA, moduleB) - MathF.Max(moduleA, moduleB);
        float multiply = moduleA * moduleB;
        float quotient = moduleA / moduleB;

        return $"Sum: {sum}, Difference: {difference}, Multiply: {multiply}, Quotient: {quotient}";
    }

    static string Begin12(float a, float b)
    {
        float c = MathF.Sqrt(MathF.Pow(a, 2) + MathF.Pow(b, 2));
        float perimeter = a + b + c;

        return $"Leg: {c}, Perimeter: {perimeter}";
    }

    static string Begin13(float R1, float R2)
    {
        float S1 = MathF.PI * MathF.Pow(R1, 2);
        float S2 = MathF.PI * MathF.Pow(R2, 2);
        float S3 = S1 - S2;

        return $"S1: {S1}, S2: {S2}, S3: {S3}";
    }

    static string Begin14(float l)
    {
        float R = l / (2 * MathF.PI);
        float S = MathF.PI * MathF.Pow(R, 2);

        return $"Radius: {R}, Square: {S}";
    }

    static string Begin15(float S)
    {
        float diameter = 2 * MathF.Sqrt(S / MathF.PI);
        float length = MathF.Sqrt(S * 4 * MathF.PI);

        return $"Diameter: {diameter}, Length: {length}";
    }

    static float Begin16(float x1, float x2)
    {
        return MathF.Abs(x2 - x1);
    }

    static string Begin17(float A, float B, float C)
    {
        float m_a = MathF.Abs(A);
        float m_b = MathF.Abs(B);
        float m_c = MathF.Abs(C);
        
        float AC = m_c - m_a;
        float BC = m_c - m_b;
        float sum = AC + BC;

        return $"AC: {AC}, BC: {BC}, Sum: {sum}";
    }

    static string Begin18(float A, float B, float C)
    {
        float m_a = MathF.Abs(A);
        float m_b = MathF.Abs(B);
        float m_c = MathF.Abs(C);
        
        if (A > C && C < B)
        {
            float AC = m_c - m_a;
            float BC = m_c - m_b;
            float product = AC * BC;

            return $"AC: {AC}, BC: {BC}, Product: {product}";
        }
        return $"Точка C не в середине точек A и B :(";
    }

    static string Begin19(float x1, float y1, float x2, float y2)
    {
        float m_x1 = MathF.Abs(x1);
        float m_x2 = MathF.Abs(x2);

        float m_y1 = MathF.Abs(y1);
        float m_y2 = MathF.Abs(y2);
        
        float side1 = m_x2 - m_x1;
        float side2 = m_y2 - m_y1;
        
        float perimeter = 2 * (side1 + side2);
        float area = side1 * side2;

        return $"Perimeter: {perimeter}, Area: {area}";
    }

    static float Begin20(float x1, float y1, float x2, float y2)
    {
        return MathF.Sqrt(MathF.Pow(x2 - x1, 2) + MathF.Pow(y2 - y1, 2));
    }

    static string Begin21(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        float distance_a = MathF.Sqrt(MathF.Pow(x2 - x1, 2) - MathF.Pow(y2 - y1, 2)); // Расстояние между координатой 1 и 2
        float distance_b = MathF.Sqrt(MathF.Pow(x3 - x2, 2) - MathF.Pow(y3 - y2, 2)); // Расттояние между координатой 2 и 3
        float distance_c = MathF.Sqrt(MathF.Pow(x3 - x1, 2) - MathF.Pow(y3 - y1, 2)); // Расстояние между координатой 3 и 1
        float half_perimeter = (distance_a + distance_b + distance_c) / 2;

        float square = MathF.Sqrt(half_perimeter * (half_perimeter - distance_a) * (half_perimeter - distance_b) *
                                  (half_perimeter - distance_c));

        return $"Perimeter: {half_perimeter * 2}, Square: {square}";
    }

    static string Begin22(string a, string b)
    {
        (a, b) = (b, a);

        return $"b = {b}, a = {a}";
    }

    static string Begin23(string a, string b, string c)
    {
        (a, b, c) = (b, c, a);
        
        return $"a: {a}, b: {b}, c: {c}";
    }

    static string Begin24(string a, string b, string c)
    {
        (a, b, c) = (c, a, b);

        return $"a: {a}, b: {b}, c: {c}";
    }

    static float Begin25(float x)
    {
        float y = MathF.Pow(3 * x, 2) - MathF.Pow(6 * x, 2) - 7;
        
        return y;
    }

    static float Begin26(float x)
    {
        float y = MathF.Pow(4 * (x - 3), 6) - MathF.Pow(7 * (x - 3), 3) + 2;
        
        return y;
    }

    static string Begin27(float a)
    {
        float temp = a;

        temp = temp * temp;
        float a2 = temp;
        temp = temp * temp;
        float a4 = temp * temp;
        temp = temp * temp;
        float a8 = temp;

        return $"A^2: {a2}, A^4: {a4}, A^8: {a8}";
    }

    static string Begin28(float a)
    {
        float temp1 = a;
        
        float temp2 = temp1 * temp1;
        float a2 = temp2;
        
        temp1 = temp1 * temp2;
        float a3 = temp1;
        
        temp2 = temp1 * temp2;
        float a5 = temp2;
        
        temp1 = temp1 * temp1;
        float a10 = temp1;
        
        temp1 = temp1 * temp2;
        float a15 = temp1;

        return $"a2: {a2}, a3: {a3}, a5: {a5}, a10: {a10}, a15: {a15}";
    }

    static float Begin29(float a)
    {
        float radians = a * MathF.PI / 180;
        return radians;
    }

    static float Begin30(float a)
    {
        float gradus = a * 180 / MathF.PI;
        return gradus;
    }
}