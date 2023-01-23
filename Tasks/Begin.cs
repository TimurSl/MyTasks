
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
        Console.WriteLine(Begin31(3));
        Console.WriteLine(Begin32(4));
        Console.WriteLine(Begin33(12, 213, 41));
        Console.WriteLine(Begin34(12, 33, 23, 13));
        Console.WriteLine(Begin35(12, 25, 54, 12));
        Console.WriteLine(Begin36(98, 23, 52, 58));
        Console.WriteLine(Begin37(12, 13, 14, 15));
        Console.WriteLine(Begin38(24, 27));
        Console.WriteLine(Begin39(87, 125, 255));
        Console.WriteLine(Begin40(12, 21, 13, 31, 14, 41, 9, 4, 3));
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
        float difference = MathF.Abs(s_a - s_b);
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
        float AC = MathF.Abs(C - A);
        float BC = MathF.Abs(C - B);
        float sum = AC + BC;

        return $"AC: {AC}, BC: {BC}, Sum: {sum}";
    }

    static string Begin18(float A, float B, float C)
    {
        if (A > C && C < B)
        {
            float AC = MathF.Abs(C - A);
            float BC = MathF.Abs(C - B);
            float product = AC * BC;

            return $"AC: {AC}, BC: {BC}, Product: {product}";
        }
        return $"Точка C не в середине точек A и B :(";
    }

    static string Begin19(float x1, float y1, float x2, float y2)
    {
        float distance_x = MathF.Abs(x1 - x2);
        float distance_y = MathF.Abs(y1 - y2);
        
        float perimeter = 2 * distance_x + distance_y;
        float area = distance_x * distance_y;

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
        float perimeter = (distance_a + distance_b + distance_c) / 2;
        float square = MathF.Sqrt(perimeter * (perimeter - distance_a) * (perimeter - distance_b) * (perimeter - distance_c));

        return $"Perimeter: {perimeter}, Square: {square}";
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
        return MathF.Pow(3 * x, 2) - MathF.Pow(6 * x, 2) - 7;
    }

    static float Begin26(float x)
    {
        return MathF.Pow(4 * (x - 3), 6) - MathF.Pow(7 * (x - 3), 3) + 2;
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

    static float Begin31(float a)
    {
        return (a - 32) * 5 / 9;
    }

    static float Begin32(float a)
    {
        return  (a * 9 / 5) + 32;
    }

    static string Begin33(int x, int a, int y)
    {
        float kg1 = a / x;
        float kgY = kg1 * y;
        
        return $"1 KG: {kg1}, Y KG: {kgY}";
    }

    static string Begin34(float chocolateMass, float chocolatePrice, float irisMass, float irisPrice)
    {
        // Известно, что X кг шоколадных конфет стоит A рублей, а Y кг ирисок стоит B рублей. Определить, сколько стоит 1 кг шоколадных конфет,1 кг ирисок, а также во сколько раз шоколадные конфеты дороже ирисок.
        float chocolatePricePerKg = chocolatePrice / chocolateMass;
        float irisPricePerKg = irisPrice / irisMass;
        
        float difference = chocolatePricePerKg / irisPricePerKg;
        
        return $"Chocolate price per kg: {chocolatePricePerKg}, Iris price per kg: {irisPricePerKg}, Difference: {difference}";
    }

    static float Begin35(float V, float U, float T1, float T2)
    {
        float S = V * T1 + (V - U) * T2;
        return S;
    }

    static float Begin36(float V1, float V2, float S, float T)
    {
        return S + V1 * T + V2 * T;
    }

    static float Begin37(float V1, float V2, float S, float T)
    {
        return MathF.Abs(S - (V1 * T + V2 * T));
    }

    static float Begin38(float a, float b)
    {
        return -1 * b / a;
    }

    static string Begin39(double a, double b, double c)
    {
        double d = Math.Pow(b, 2) - 4 * a * c;
        double x1 = ((-1f) * b + Math.Sqrt(d)) / (2f * a);
        double x2 = ((-1f) * b - Math.Sqrt(d)) / (2f * a);
        
        if (x1 > x2)
        {
            return $"X1 bigger than x2";
        }
        else
        {
            return $"X1 smaller X2";
        }

        return $"X1: {x1}, X2: {x2}";
    }

    static string Begin40(double a1, double a2, double b1, double b2, double c1, double c2, double d, double x, double y)
    {
        d = a1* b2 - b1 * a2;
        x = (c1 * b2 - c2* b1) / d;
        y = (a1 * c2 - a2 * c1) / d;

        return $"X: {x}, Y: {y}";
    }
}