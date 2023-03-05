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
        Console.WriteLine(ArrayToString(Array13(Array1(11))));
        Console.WriteLine(ArrayToString(Array14(Array1(10))));
        Console.WriteLine(ArrayToString(Array15(Array1(10))));
        Console.WriteLine(ArrayToString(Array16(Array1(10))));
        Console.WriteLine(ArrayToString(Array17(Array1(10))));
        Console.WriteLine(Array18(Array1(10)));
        Console.WriteLine(Array19(Array1(10)));
        Console.WriteLine(Array20(Array1(10), 5, 10));
        Console.WriteLine(Array21(Array1(10), 5, 10));
        Console.WriteLine(Array22(Array1(10), 5, 10));
        Console.WriteLine(Array23(Array1(10), 5, 10));
        Console.WriteLine(Array24(Array1(10)));
        Console.WriteLine(Array25(Array1(10)));
        Console.WriteLine(Array26(Array1(10)));
        Console.WriteLine(Array27(Array1(10)));
        Console.WriteLine(Array28(Array1(10)));
        Console.WriteLine(Array29(Array1(10)));
        Console.WriteLine(Array30(Array1(10)));
        Console.WriteLine(Array31(Array1(10)));
        Console.WriteLine(Array32(Array1(10)));
        Console.WriteLine(Array33(Array1(10)));
        Console.WriteLine(Array34(Array1(10)));
        Console.WriteLine(Array35(Array1(10)));
        Console.WriteLine(Array36(Array1(10)));
        Console.WriteLine(Array37(Array1(10)));
        Console.WriteLine(Array38(Array1(10)));
        Console.WriteLine(Array39(Array1(10)));
        Console.WriteLine(Array40(Array1(10), 5));
        Console.WriteLine(Array41(Array1(10)));
        Console.WriteLine(Array42(Array1(10), 6));
        Console.WriteLine(Array43(Array1(10)));
        Console.WriteLine(Array44(Array1(10)));
        Console.WriteLine(Array45(Array1(10)));
        Console.WriteLine(Array46(Array1(10)));
        Console.WriteLine(Array47(Array1(10)));
        Console.WriteLine(Array48(Array1(10)));
        Console.WriteLine(Array49(Array1(10)));
        Console.WriteLine(Array50(Array1(10)));
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
        int[] arrayOdd = Array8(array);
        int[] arrayEven = Array9(array);
        
        for (int i = 0; i < arrayEven.Length; i++)
        {
            arrayEven[i] = i + 1;
        }
        int[] arrayMerged = new int[array.Length];
        for (int i = 0; i < arrayOdd.Length; i++)
        {
            arrayMerged[i] = arrayOdd[i];
        }
        for (int i = 0; i < arrayEven.Length; i++)
        {
            arrayMerged[i + arrayOdd.Length] = arrayEven[arrayEven.Length - i - 1];
        }
        return arrayMerged;
    }
    
    public static int[] Array15(int[] array)
    {
        int[] arrayEven = Array9(array);
        int[] arrayOdd = Array8(array);
        int[] arrayMerged = new int[array.Length];
        for (int i = 0; i < arrayEven.Length; i++)
        {
            arrayMerged[i] = arrayEven[i];
        }
        for (int i = 0; i < arrayOdd.Length; i++)
        {
            arrayMerged[i + arrayEven.Length] = arrayOdd[arrayOdd.Length - i - 1];
        }
        return arrayMerged;
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
    
    public static double Array21(int[] array, int k, int l)
    {
        double sum = 0;
        for (int i = k - 1; i < l; i++)
        {
            sum += array[i];
        }
        return sum / (l - k + 1);
    }
    
    public static int Array22(int[] array, int k, int l)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i < k - 1 || i > l - 1)
            {
                sum += array[i];
            }
        }
        return sum;
    }
    
    public static double Array23(int[] array, int k, int l)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i < k - 1 || i > l - 1)
            {
                sum += array[i];
            }
        }
        return sum / (array.Length - (l - k + 1));
    }
    
    public static int Array24(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] - array[i] == array[1] - array[0])
            {
                k = array[i + 1] - array[i];
            }
            else
            {
                k = 0;
                break;
            }
        }
        return k;
    }
    
    public static int Array25(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] / array[i] == array[1] / array[0])
            {
                k = array[i + 1] / array[i];
            }
            else
            {
                k = 0;
                break;
            }
        }
        return k;
    }
    
    public static int Array26(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] % 2 == 0 && array[i + 1] % 2 != 0)
            {
                k = 0;
            }
            else if (array[i] % 2 != 0 && array[i + 1] % 2 == 0)
            {
                k = 0;
            }
            else
            {
                k = i + 1;
                break;
            }
        }
        return k;
    }
    
    public static int Array27(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > 0 && array[i + 1] < 0)
            {
                k = 0;
            }
            else if (array[i] < 0 && array[i + 1] > 0)
            {
                k = 0;
            }
            else
            {
                k = i + 1;
                break;
            }
        }
        return k;
    }
    
    public static int Array28(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] < array[k])
                {
                    k = i;
                }
            }
        }
        return array[k];
    }
    
    public static int Array29(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                if (array[i] > array[k])
                {
                    k = i;
                }
            }
        }
        return array[k];
    }
    
    public static int Array30(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array31(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0)
            {
                if (array[i] > array[i - 1])
                {
                    k++;
                }
            }
        }
        return k;
    }
    
    public static int Array32(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i < array.Length - 1)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    k = i + 1;
                    break;
                }
            }
        }
        return k;
    }
    
    public static int Array33(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i < array.Length - 1)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    k = i + 1;
                }
            }
        }
        return k;
    }
    
    public static int Array34(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i < array.Length - 1)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    if (array[i] > k)
                    {
                        k = array[i];
                    }
                }
            }
        }
        return k;
    }
    
    public static int Array35(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i < array.Length - 1)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    if (array[i] < k)
                    {
                        k = array[i];
                    }
                }
            }
        }
        return k;
    }
    
    public static int Array36(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i < array.Length - 1)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    if (array[i] > k)
                    {
                        k = array[i];
                    }
                }
            }
        }
        return k;
    }
    
    public static int Array37(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array38(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array39(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array40(int[] array, int r)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - r) < Math.Abs(array[k] - r))
            {
                k = i;
            }
        }
        return array[k];
    }
    
    public static int Array41(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + array[i + 1] > array[k] + array[k + 1])
            {
                k = i;
            }
        }
        return k;
    }

    public static int Array42(int[] array, int r)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (Math.Abs(array[i] + array[i + 1] - r) < Math.Abs(array[k] + array[k + 1] - r))
            {
                k = i;
            }
        }
        return k;
    }
    
    public static int Array43(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] != array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array44(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                k = i;
                break;
            }
        }
        return k;
    }
    
    public static int Array45(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (Math.Abs(array[i] - array[i + 1]) < Math.Abs(array[k] - array[k + 1]))
            {
                k = i;
            }
        }
        return k;
    }
    
    public static int Array46(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                k = i;
                break;
            }
        }
        return k;
    }
    
    public static int Array47(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] != array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array48(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                k++;
            }
        }
        return k;
    }
    
    public static int Array49(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != i + 1)
            {
                k = i + 1;
                break;
            }
        }
        return k;
    }
    
    public static int Array50(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    k++;
                }
            }
        }
        return k;
    }
}