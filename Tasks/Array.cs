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
    
    
}