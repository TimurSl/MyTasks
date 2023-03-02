namespace Tasks;

public class Array
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ArrayToString(Array1(10)));
        Console.WriteLine(ArrayToString(Array2(10)));
        Console.WriteLine(ArrayToString(Array3(10, 1, 2)));
        Console.WriteLine(ArrayToString(Array4(10, 1, 2)));
        Console.WriteLine(ArrayToString(Array5(10)));
        Console.WriteLine(ArrayToString(Array6(10, 1, 1)));
        Console.WriteLine(ArrayToString(Array7(10)));
        Console.WriteLine(ArrayToString(Array8(Array1(10))));
        Console.WriteLine(ArrayToString(Array9(Array1(10))));
        Console.WriteLine(ArrayToString(Array10(Array1(10))));
        Console.WriteLine(ArrayToString(Array11(Array1(10), 10)));
        Console.WriteLine(ArrayToString(Array12(Array1(10))));
        Console.WriteLine(ArrayToString(Array13(Array1(10))));
        Console.WriteLine(ArrayToString(Array14(Array1(10))));
        Console.WriteLine(ArrayToString(Array15(Array1(10))));
        Console.WriteLine(ArrayToString(Array16(Array1(10))));
        Console.WriteLine(ArrayToString(Array17(Array1(10))));
        Console.WriteLine(Array18(Array1(10)));
        Console.WriteLine(Array19(Array1(10)));
        Console.WriteLine(Array20(Array1(10), 5, 10));
    }
    
    public static string ArrayToString(int[] array)
    {
        string s = "";
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] + " ";
        }
        return s;
    }
    
    public static int[] Array1(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = 2 * i + 1;
        }
        return array;
    }
    
    public static int[] Array2(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = (int)Math.Pow(2, i);
        }
        return array;
    }
    
    public static int[] Array3(int n, int a, int d)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = a + i * d;
        }
        return array;
    }
    
    public static int[] Array4(int n, int a, int d)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = a * (int)Math.Pow(d, i);
        }
        return array;
    }
    
    public static int[] Array5(int n)
    {
        int[] array = new int[n];
        array[0] = 1;
        array[1] = 1;
        for (int i = 2; i < n; i++)
        {
            array[i] = array[i - 2] + array[i - 1];
        }
        return array;
    }
    
    public static int[] Array6(int n, int a, int b)
    {
        int[] array = new int[n];
        array[0] = a;
        array[1] = b;
        for (int i = 2; i < n; i++)
        {
            array[i] = array[i - 2] + array[i - 1];
        }
        return array;
    }
    
    public static int[] Array7(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    
    public static int[] Array8(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                k++;
            }
        }
        int[] array2 = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                array2[j] = array[i];
                j++;
            }
        }
        return array2;
    }
    
    public static int[] Array9(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                k++;
            }
        }
        int[] array2 = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array2[j] = array[i];
                j++;
            }
        }
        return array2;
    }
    
    public static int[] Array10(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                k++;
            }
        }
        int[] array2 = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array2[j] = array[i];
                j++;
            }
        }
        int[] array3 = new int[array.Length - k];
        j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                array3[j] = array[i];
                j++;
            }
        }
        int[] array4 = new int[array.Length];
        for (int i = 0; i < array2.Length; i++)
        {
            array4[i] = array2[i];
        }
        for (int i = 0; i < array3.Length; i++)
        {
            array4[i + array2.Length] = array3[array3.Length - i - 1];
        }
        return array4;
    }
    
    public static int[] Array11(int[] array, int k)
    {
        int[] array2 = new int[array.Length / k];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[i * k];
        }
        return array2;
    }
    
    public static int[] Array12(int[] array)
    {
        int[] array2 = new int[array.Length / 2];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[i * 2];
        }
        return array2;
    }
    
    public static int[] Array13(int[] array)
    {
        int[] array2 = new int[array.Length / 2 + 1];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[array.Length - i * 2 - 1];
        }
        return array2;
    }
    
    public static int[] Array14(int[] array)
    {
        int[] array2 = new int[array.Length / 2];
        int[] array3 = new int[array.Length / 2 + 1];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[i * 2];
        }
        for (int i = 0; i < array3.Length; i++)
        {
            array3[i] = array[array.Length - i * 2 - 1];
        }
        int[] array4 = new int[array.Length];
        for (int i = 0; i < array2.Length; i++)
        {
            array4[i] = array2[i];
        }
        for (int i = 0; i < array3.Length; i++)
        {
            array4[i + array2.Length] = array3[i];
        }
        return array4;
    }
    
    public static int[] Array15(int[] array)
    {
        int[] array2 = new int[array.Length / 2];
        int[] array3 = new int[array.Length / 2 + 1];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[i * 2];
        }
        for (int i = 0; i < array3.Length; i++)
        {
            array3[i] = array[array.Length - i * 2 - 1];
        }
        int[] array4 = new int[array.Length];
        for (int i = 0; i < array2.Length; i++)
        {
            array4[i] = array2[i];
        }
        for (int i = 0; i < array3.Length; i++)
        {
            array4[i + array2.Length] = array3[i];
        }
        return array4;
    }
    
    public static int[] Array16(int[] array)
    {
        int[] array2 = new int[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            array2[i * 2] = array[i];
            array2[i * 2 + 1] = array[array.Length - i - 1];
        }
        if (array.Length % 2 != 0)
        {
            array2[array.Length - 1] = array[array.Length / 2];
        }
        return array2;
    }
    
    public static int[] Array17(int[] array)
    {
        int[] array2 = new int[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            array2[i * 2] = array[i];
            array2[i * 2 + 1] = array[array.Length - i - 1];
        }
        if (array.Length % 2 != 0)
        {
            array2[array.Length - 1] = array[array.Length / 2];
        }
        return array2;
    }
    
    public static int Array18(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[array.Length - 1])
            {
                k = array[i];
                break;
            }
        }
        return k;
    }
    
    public static int Array19(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[0] && array[i] < array[array.Length - 1])
            {
                k = i;
            }
        }
        return k;
    }
    
    public static int Array20(int[] array, int k, int l)
    {
        int sum = 0;
        for (int i = k - 1; i < l; i++)
        {
            sum += array[i];
        }
        return sum;
    }
 
}