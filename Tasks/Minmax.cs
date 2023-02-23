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
}