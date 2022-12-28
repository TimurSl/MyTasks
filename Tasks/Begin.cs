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
        float sum = MathF.Sqrt(a) + MathF.Sqrt(b);
        float difference = MathF.Max(MathF.Sqrt(a), MathF.Sqrt(b)) - MathF.Min(MathF.Sqrt(a), MathF.Sqrt(b));
        float multiply = MathF.Sqrt(a) * MathF.Sqrt(b);
        float quotient = MathF.Sqrt(a) / MathF.Sqrt(b);

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
        float AC = C - A;
        float BC = C - B;
        float sum = AC + BC;

        return $"AC: {AC}, BC: {BC}, Sum: {sum}";
    }

    static string Begin18(float A, float B, float C)
    {
        if (A > C && C < B)
        {
            float AC = C - A;
            float BC = C - B;
            float product = AC * BC;

            return $"AC: {AC}, BC: {BC}, Product: {product}";
        }
        return $"Точка C не в середине точек A и B :(";
    }

    static string Begin19(float x1, float y1, float x2, float y2)
    {
        float side1 = x2 - x1;
        float side2 = y2 - y1;
        float perimeter = 2 * (side1 + side2);
        float area = side1 * side2;

        return $"Perimeter: {perimeter}, Area: {area}";
    }

    static float Begin20(float x1, float y1, float x2, float y2)
    {
        return MathF.Sqrt(MathF.Pow(x2 - x1, 2) + MathF.Pow(y2 - y1, 2));
    }
}