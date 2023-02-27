namespace Tasks;

public class Minmax
{
    public static void Main(string[] args)
    {
        Minmax1(3, new int[] { 1, 2, 3 });
        Minmax2(3, new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } });
        Minmax3(3, new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } });
        Minmax4(3, new int[] { 1, 2, 3 });
        Minmax5(3, new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } });
        Minmax6(3, new int[] { 1, 2, 3 });
        Minmax7(3, new int[] { 1, 2, 3 });
        Minmax8(3, new int[] { 1, 2, 3 });
        Minmax9(3, new int[] { 1, 2, 3 });
        Minmax10(3, new int[] { 1, 2, 3 });
        Minmax11(3, new int[] { 1, 2, 3 });
        Minmax12(3, new int[] { 1, 2, 3 });
        Minmax13(3, new int[] { 1, 2, 3 });
        Minmax14(3, new int[] { 1, 2, 3 }, 3);
        Minmax15(3, new int[] { 1, 2, 3 }, 2, 1);
        Minmax16(3, new int[] { 1, 2, 3 });
        Minmax17(3, new int[] { 1, 2, 3 });
        Minmax18(3, new int[] { 1, 2, 3 });
        Minmax19(3, new int[] { 1, 2, 3 });
        Minmax20(3, new int[] { 1, 2, 3 });
        Minmax21(3, new int[] { 1, 2, 3 });
        Minmax22(3, new int[] { 1, 2, 3 });
        Minmax23(3, new int[] { 1, 2, 3 });
        Minmax24(3, new int[] { 1, 2, 3 });
        Minmax25(3, new int[] { 1, 2, 3 });
        Minmax26(3, new int[] { 1, 2, 3 });
        Minmax27(3, new int[] { 1, 2, 3 });
        Minmax28(3, new int[] { 1, 2, 3 });
        Minmax29(3, new int[] { 1, 2, 3 });
        Minmax30(3, new int[] { 1, 2, 3 });
    }

    public static void Minmax1(int n, int[] num)
    {
        int min = num[0];
        int max = num[0];
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        Console.WriteLine(min + " " + max);
    }
    
    public static void Minmax2(int n, List<int[]> num)
    {
        int min = num[0][0] * num[0][1];
        for (int i = 1; i < n; i++)
        {
            if (num[i][0] * num[i][1] < min)
            {
                min = num[i][0] * num[i][1];
            }
        }
        Console.WriteLine(min);
    }

    public static void Minmax3(int n, List<int[]> num)
    {
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i][0] * num[i][1] > max)
            {
                max = num[i][0] * num[i][1];
            }
        }
        Console.WriteLine(max);
    }
    
    public static void Minmax4(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex);
    }
    
    public static void Minmax5(int n, List<int[]> num)
    {
        int max = 0;
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i][0] / num[i][1] > max)
            {
                max = num[i][0] / num[i][1];
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex + " " + max);
    }
    
    public static void Minmax6(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(minIndex + " " + maxIndex);
    }
    
    public static void Minmax7(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex + " " + minIndex);
    }
    
    // Minmax8. Дано целое числоNи набор изNцелых чисел. Найти номера пер-вого и последнего минимального элемента из данного набора и вывестиих в указанном порядке.
    public static void Minmax8(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(minIndex + " " + maxIndex);
    }
    
    public static void Minmax9(int n, int[] num)
    {
        int maxIndex1 = 0;
        int max1 = num[0];
        int maxIndex2 = 0;
        int max2 = num[0];
        
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max1)
            {
                max1 = num[i];
                maxIndex1 = i;
            }
            
            if (num[i] > max2 && num[i] < max1)
            {
                max2 = num[i];
                maxIndex2 = i;
            }
            
        }
        Console.WriteLine(maxIndex1 + " " + maxIndex2);
    }
    
    public static void Minmax10(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        if (minIndex < maxIndex)
        {
            Console.WriteLine(minIndex);
        }
        else
        {
            Console.WriteLine(maxIndex);
        }
    }
    
    public static void Minmax11(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        if (minIndex > maxIndex)
        {
            Console.WriteLine(minIndex);
        }
        else
        {
            Console.WriteLine(maxIndex);
        }
    }
    
    public static void Minmax12(int n, int[] num)
    {
        int min = num[0];
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min && num[i] > 0)
            {
                min = num[i];
            }
        }
        Console.WriteLine(min);
    }
    
    public static void Minmax13(int n, int[] num)
    {
        int max = 0;
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] > max && num[i] % 2 != 0)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex);
    }
    
    public static void Minmax14(int n, int[] num, int b)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min && num[i] > b)
            {
                min = num[i];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex + " " + min);
    }
    
    public static void Minmax15(int n, int[] num, int b, int c)
    {
        int max = 0;
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] > max && num[i] > b && num[i] < c)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex + " " + max);
    }
    
    public static void Minmax16(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex);
    }
    
    public static void Minmax17(int n, int[] num)
    {
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine(n - maxIndex - 1);
    }
    
    public static void Minmax18(int n, int[] num)
    {
        int max = num[0];
        int maxIndex = 0;
        int maxIndex2 = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                maxIndex2 = i;
            }
        }
        Console.WriteLine(maxIndex2 - maxIndex - 1);
    }
    
    public static void Minmax19(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] == min)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    
    public static void Minmax20(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] == min || num[i] == max)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    
    public static void Minmax21(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (i != minIndex && i != maxIndex)
            {
                sum += num[i];
            }
        }
        Console.WriteLine(sum / (n - 2));
    }
    
    public static void Minmax22(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        int min2 = num[0];
        int minIndex2 = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min2 && i != minIndex)
            {
                min2 = num[i];
                minIndex2 = i;
            }
        }
        if (min < min2)
        {
            Console.WriteLine(min + " " + min2);
        }
        else
        {
            Console.WriteLine(min2 + " " + min);
        }
    }
    
    public static void Minmax23(int n, int[] num)
    {
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        int max2 = num[0];
        int maxIndex2 = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max2 && i != maxIndex)
            {
                max2 = num[i];
                maxIndex2 = i;
            }
        }
        int max3 = num[0];
        int maxIndex3 = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max3 && i != maxIndex && i != maxIndex2)
            {
                max3 = num[i];
                maxIndex3 = i;
            }
        }
        Console.WriteLine(max + " " + max2 + " " + max3);
    }
    
    public static void Minmax24(int n, int[] num)
    {
        int max = num[0] + num[1];
        for (int i = 1; i < n - 1; i++)
        {
            if (num[i] + num[i + 1] > max)
            {
                max = num[i] + num[i + 1];
            }
        }
        Console.WriteLine(max);
    }
    
    public static void Minmax25(int n, int[] num)
    {
        int min = num[0] * num[1];
        int minIndex = 0;
        for (int i = 1; i < n - 1; i++)
        {
            if (num[i] * num[i + 1] < min)
            {
                min = num[i] * num[i + 1];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex + " " + (minIndex + 1));
    }
    
    public static void Minmax26(int n, int[] num)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] % 2 == 0)
            {
                count++;
            }
            else
            {
                if (count > max)
                {
                    max = count;
                }
                count = 0;
            }
        }
        if (count > max)
        {
            max = count;
        }
        Console.WriteLine(max);
    }
    
    public static void Minmax27(int n, int[] num)
    {
        int max = 0;
        int count = 0;
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] == 0)
            {
                count++;
            }
            else
            {
                if (count > max)
                {
                    max = count;
                    index = i - count;
                }
                count = 0;
            }
        }
        if (count > max)
        {
            max = count;
            index = n - count;
        }
        Console.WriteLine(index + " " + max);
    }
    
    public static void Minmax28(int n, int[] num)
    {
        int max = 0;
        int count = 0;
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] == 1)
            {
                count++;
            }
            else
            {
                if (count > max)
                {
                    max = count;
                    index = i - count;
                }
                count = 0;
            }
        }
        if (count > max)
        {
            max = count;
            index = n - count;
        }
        if (max == 0)
        {
            Console.WriteLine("0 0");
        }
        else
        {
            Console.WriteLine(index + " " + max);
        }
    }
    
    public static void Minmax29(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        int count = 1;
        int max = 1;
        for (int i = minIndex + 1; i < n; i++)
        {
            if (num[i] == min)
            {
                count++;
            }
            else
            {
                if (count > max)
                {
                    max = count;
                }
                count = 1;
            }
        }
        if (count > max)
        {
            max = count;
        }
        Console.WriteLine(max);
    }
    
    public static void Minmax30(int n, int[] num)
    {
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        int count = 1;
        int min = 1;
        for (int i = maxIndex + 1; i < n; i++)
        {
            if (num[i] == max)
            {
                count++;
            }
            else
            {
                if (count < min)
                {
                    min = count;
                }
                count = 1;
            }
        }
        if (count < min)
        {
            min = count;
        }
        Console.WriteLine(min);
    }
}