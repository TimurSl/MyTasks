namespace Tasks;

public class Case
{
    public static void Main(string[] args)
    {
        Case1(1);
        Case2(2);
        Case3(3);
        Case4(4);
        Case5(5, 6, 7);
        Case6(8, 9);
        Case7(10, 11);
        Case8(12, 13);
        Case9(14, 15);
        Case10(char.Parse("Ю"), 1);
    }

    public static void Case1(int a)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Нет такого дня недели");
                break;
        }
    }

    public static void Case2(int k)
    {
        switch (k)
        {
            case 1:
                Console.WriteLine("Плохо");
                break;
            case 2:
                Console.WriteLine("Неудовлетворительно");
                break;
            case 3:
                Console.WriteLine("Удовлетворительно");
                break;
            case 4:
                Console.WriteLine("Хорошо");
                break;
            case 5:
                Console.WriteLine("Отлично");
                break;
            default:
                Console.WriteLine("Нет такой оценки");
                break;
        }
    }

    public static void Case3(int a)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine("Январь");
                break;
            case 2:
                Console.WriteLine("Февраль");
                break;
            case 3:
                Console.WriteLine("Март");
                break;
            case 4:
                Console.WriteLine("Апрель");
                break;
            case 5:
                Console.WriteLine("Май");
                break;
            case 6:
                Console.WriteLine("Июнь");
                break;
            case 7:
                Console.WriteLine("Июль");
                break;
            case 8:
                Console.WriteLine("Август");
                break;
            case 9:
                Console.WriteLine("Сентябрь");
                break;
            case 10:
                Console.WriteLine("Октябрь");
                break;
            case 11:
                Console.WriteLine("Ноябрь");
                break;
            case 12:
                Console.WriteLine("Декабрь");
                break;
            
            default:
                Console.WriteLine("Нет такого месяца");
                break;
        }   
    }
    
    public static void Case4(int a)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine("31");
                break;
            case 2:
                Console.WriteLine("28");
                break;
            case 3:
                Console.WriteLine("31");
                break;
            case 4:
                Console.WriteLine("30");
                break;
            case 5:
                Console.WriteLine("31");
                break;
            case 6:
                Console.WriteLine("30");
                break;
            case 7:
                Console.WriteLine("31");
                break;
            case 8:
                Console.WriteLine("31");
                break;
            case 9:
                Console.WriteLine("30");
                break;
            case 10:
                Console.WriteLine("31");
                break;
            case 11:
                Console.WriteLine("30");
                break;
            case 12:
                Console.WriteLine("31");
                break;
            
            default:
                Console.WriteLine("Нет такого месяца");
                break;
        }   
    }
    
    public static void Case5(int a, int b, int c)
    {
        switch (c)
        {
            case 1:
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("Нет такого действия");
                break;
        }
    }
    
    public static void Case6(int a, double b)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine(b * 0.1);
                break;
            case 2:
                Console.WriteLine(b * 1000);
                break;
            case 3:
                Console.WriteLine(b);
                break;
            case 4:
                Console.WriteLine(b * 0.001);
                break;
            case 5:
                Console.WriteLine(b * 0.01);
                break;
            default:
                Console.WriteLine("Нет такой единицы измерения");
                break;
        }
    }
    
    public static void Case7(int a, double b)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine(b);
                break;
            case 2:
                Console.WriteLine(b * 0.000001);
                break;
            case 3:
                Console.WriteLine(b * 0.001);
                break;
            case 4:
                Console.WriteLine(b * 1000);
                break;
            case 5:
                Console.WriteLine(b * 100);
                break;
            default:
                Console.WriteLine("Нет такой единицы измерения");
                break;
        }
    }
    
    public static void Case8(int a, int b)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine("31" + " " + "12");
                break;
            case 2:
                Console.WriteLine("31" + " " + "1");
                break;
            case 3:
                Console.WriteLine("28" + " " + "2");
                break;
            case 4:
                Console.WriteLine("31" + " " + "3");
                break;
            case 5:
                Console.WriteLine("30" + " " + "4");
                break;
            case 6:
                Console.WriteLine("31" + " " + "5");
                break;
            case 7:
                Console.WriteLine("30" + " " + "6");
                break;
            case 8:
                Console.WriteLine("31" + " " + "7");
                break;
            case 9:
                Console.WriteLine("31" + " " + "8");
                break;
            case 10:
                Console.WriteLine("30" + " " + "9");
                break;
            case 11:
                Console.WriteLine("31" + " " + "10");
                break;
            case 12:
                Console.WriteLine("30" + " " + "11");
                break;
            
            default:
                Console.WriteLine("Нет такого месяца");
                break;
        }   
    }
    
    public static void Case9(int d, int m)  
    {
        switch (m)
        {
            case 1:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 2:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 3:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 4:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 5:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 6:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 7:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 8:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 9:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 10:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 11:
                Console.WriteLine(d + 1 + " " + m);
                break;
            case 12:
                Console.WriteLine(d + 1 + " " + m);
                break;
            
            default:
                Console.WriteLine("Нет такого месяца");
                break;
        }
    }
    
    public static void Case10(char c, int n)
    {
        switch (c)
        {
            case 'С':
                switch (n)
                {
                    case 0:
                        Console.WriteLine("С");
                        break;
                    case 1:
                        Console.WriteLine("З");
                        break;
                    case -1:
                        Console.WriteLine("В");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }
                break;
            case 'З':
                switch (n)
                {
                    case 0:
                        Console.WriteLine("З");
                        break;
                    case 1:
                        Console.WriteLine("Ю");
                        break;
                    case -1:
                        Console.WriteLine("С");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }
                break;
            case 'Ю':
                switch (n)
                {
                    case 0:
                        Console.WriteLine("Ю");
                        break;
                    case 1:
                        Console.WriteLine("В");
                        break;
                    case -1:
                        Console.WriteLine("З");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }
                break;
            case 'В':
                switch (n)
                {
                    case 0:
                        Console.WriteLine("В");
                        break;
                    case 1:
                        Console.WriteLine("С");
                        break;
                    case -1:
                        Console.WriteLine("Ю");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }
                break;
            default:
                Console.WriteLine("Нет такого направления");
                break;
        }
    }

}