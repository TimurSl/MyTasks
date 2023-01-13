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
        Case11(char.Parse("Ю"), 2, 3);
        Case12(1, 20);
        Case13(1, 21);
        Case14(1, 22);
        Case15(1, 23);
        Case16(21);
        Case17(3);
        Case18(467);
        Case19(5);
        Case20(23, 9);
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

    public static void Case11(char c, int n1, int n2)
    {
        char final_direction = c;
        switch (c)
        {
            case 'С':
                switch (n1)
                {
                    case 1:
                        final_direction = 'З';
                        break;
                    case -1:
                        final_direction = 'В';
                        break;
                    case 2:
                        final_direction = 'Ю';
                        break;
                }
                break;
            case 'З':
                switch (n1)
                {
                    case 1:
                        final_direction = 'Ю';
                        break;
                    case -1:
                        final_direction = 'С';
                        break;
                    case 2:
                        final_direction = 'В';
                        break;
                }
                break;
            case 'Ю':
                switch (n1)
                {
                    case 1:
                        final_direction = 'В';
                        break;
                    case -1:
                        final_direction = 'З';
                        break;
                    case 2:
                        final_direction = 'С';
                        break;
                }
                break;
            case 'В':
                switch (n1)
                {
                    case 1:
                        final_direction = 'С';
                        break;
                    case -1:
                        final_direction = 'Ю';
                        break;
                    case 2:
                        final_direction = 'З';
                        break;
                }
                break;
        }
        switch (final_direction)
        {
            case 'С':
                switch (n2)
                {
                    case 1:
                        final_direction = 'З';
                        break;
                    case -1:
                        final_direction = 'В';
                        break;
                    case 2:
                        final_direction = 'Ю';
                        break;
                }
                break;
            case 'З':
                switch (n2)
                {
                    case 1:
                        final_direction = 'Ю';
                        break;
                    case -1:
                        final_direction = 'С';
                        break;
                    case 2:
                        final_direction = 'В';
                        break;
                }
                break;
            case 'Ю':
                switch (n2)
                {
                    case 1:
                        final_direction = 'В';
                        break;
                    case -1:
                        final_direction = 'З';
                        break;
                    case 2:
                        final_direction = 'С';
                        break;
                }
                break;
            case 'В':
                switch (n2)
                {
                    case 1:
                        final_direction = 'С';
                        break;
                    case -1:
                        final_direction = 'Ю';
                        break;
                    case 2:
                        final_direction = 'З';
                        break;
                }
                break;
        }
        
        Console.WriteLine(final_direction);
    }
    
    public static void Case12(int n, double value)
    {
        double R = 0;
        double D = 0;
        double L = 0;
        double S = 0;
        switch (n)
        {
            case 1:
                R = value;
                D = 2 * R;
                L = 2 * 3.14 * R;
                S = 3.14 * R * R;
                break;
            case 2:
                D = value;
                R = D / 2;
                L = 2 * 3.14 * R;
                S = 3.14 * R * R;
                break;
            case 3:
                L = value;
                R = L / (2 * 3.14);
                D = 2 * R;
                S = 3.14 * R * R;
                break;
            case 4:
                S = value;
                R = Math.Sqrt(S / 3.14);
                D = 2 * R;
                L = 2 * 3.14 * R;
                break;
        }
        Console.WriteLine("R = {0}, D = {1}, L = {2}, S = {3}", R, D, L, S);
    }
    
    public static void Case13(int n, double value)
    {
        double a = 0;
        double c = 0;
        double h = 0;
        double S = 0;
        switch (n)
        {
            case 1:
                a = value;
                c = a * Math.Sqrt(2);
                h = c / 2;
                S = c * h / 2;
                break;
            case 2:
                c = value;
                a = c / Math.Sqrt(2);
                h = c / 2;
                S = c * h / 2;
                break;
            case 3:
                h = value;
                c = h * 2;
                a = c / Math.Sqrt(2);
                S = c * h / 2;
                break;
            case 4:
                S = value;
                c = Math.Sqrt(S * 2);
                a = c / Math.Sqrt(2);
                h = c / 2;
                break;
        }
        Console.WriteLine("a = {0}, c = {1}, h = {2}, S = {3}", a, c, h, S);
    }
    
    public static void Case14(int n, double value)
    {
        double a = 0;
        double R1 = 0;
        double R2 = 0;
        double S = 0;
        switch (n)
        {
            case 1:
                a = value;
                R1 = a * Math.Sqrt(3) / 6;
                R2 = 2 * R1;
                S = a * a * Math.Sqrt(3) / 4;
                break;
            case 2:
                R1 = value;
                a = R1 * 6 / Math.Sqrt(3);
                R2 = 2 * R1;
                S = a * a * Math.Sqrt(3) / 4;
                break;
            case 3:
                R2 = value;
                R1 = R2 / 2;
                a = R1 * 6 / Math.Sqrt(3);
                S = a * a * Math.Sqrt(3) / 4;
                break;
            case 4:
                S = value;
                a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                R1 = a * Math.Sqrt(3) / 6;
                R2 = 2 * R1;
                break;
        }
        Console.WriteLine("a = {0}, R1 = {1}, R2 = {2}, S = {3}", a, R1, R2, S);
    }
    
    public static void Case15(int n, int m)
    {
        // Сделать через switch
        string mast = String.Empty;
        string card = String.Empty;
        switch (n)
        {
            case 1:
                mast = "пик";
                break;
            case 2:
                mast = "треф";
                break;
            case 3:
                mast = "бубен";
                break;
            case 4:
                mast = "червей";
                break;
        }
        switch (m)
        {
            case 1:
                card = "туз";
                break;
            case 2:
                card = "2";
                break;
            case 3:
                card = "3";
                break;
            case 4:
                card = "4";
                break;
            case 5:
                card = "5";
                break;
            case 6:
                card = "6";
                break;
            case 7:
                card = "7";
                break;
            case 8:
                card = "8";
                break;
            case 9:
                card = "9";
                break;
            case 10:
                card = "10";
                break;
            case 11:
                card = "валет";
                break;
            case 12:
                card = "дама";
                break;
            case 13:
                card = "король";
                break;
        }
    }
    
    public static void Case16(int n)
    {
        if (n < 20 || n > 69) {
            Console.WriteLine("Неверный год");
            return;
        }

        string[] ones = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] tens = { "двадцать", "тридцать", "сорок", "пятьдесят" };

        string result = tens[(n - 20) / 10];
        if (n % 10 != 0) {
            result += " " + ones[n  % 10];
        }

        if (n % 10 == 1) {
            result += " год";
        } else if (n % 10 >= 2 && n % 10 <= 4) {
            result += " года";
        } else {
            result += " лет";
        }
        
        Console.WriteLine(result);
    }

    public static void Case17(int n)
    {
        string num = String.Empty;
        switch (n)
        {
            case 1:
                num = "один";
                break;
            case 2:
                num = "два";
                break;
            case 3:
                num = "три";
                break;
            case 4:
                num = "четыре";
                break;
            case 5:
                num = "пять";
                break;
            case 6:
                num = "шесть";
                break;
            case 7:
                num = "семь";
                break;
            case 8:
                num = "восемь";
                break;
            case 9:
                num = "девять";
                break;
            case 10:
                num = "десять";
                break;
            case 11:
                num = "одиннадцать";
                break;
            case 12:
                num = "двенадцать";
                break;
            case 13:
                num = "тринадцать";
                break;
            case 14:
                num = "четырнадцать";
                break;
            case 15:
                num = "пятнадцать";
                break;
            case 16:
                num = "шестнадцать";
                break;
            case 17:
                num = "семнадцать";
                break;
            case 18:
                num = "восемнадцать";
                break;
            case 19:
                num = "девятнадцать";
                break;
            case 20:
                num = "двадцать";
                break;
            case 21:
                num = "двадцать один";
                break;
            case 22:
                num = "двадцать два";
                break;
            case 23:
                num = "двадцать три";
                break;
            case 24:
                num = "двадцать четыре";
                break;
            case 25:
                num = "двадцать пять";
                break;
            case 26:
                num = "двадцать шесть";
                break;
            case 27:
                num = "двадцать семь";
                break;
            case 28:
                num = "двадцать восемь";
                break;
            case 29:
                num = "двадцать девять";
                break;
            case 30:
                num = "тридцать";
                break;
            case 31:
                num = "тридцать один";
                break;
            case 32:
                num = "тридцать два";
                break;
            case 33:
                num = "тридцать три";
                break;
            case 34:
                num = "тридцать четыре";
                break;
            case 35:
                num = "тридцать пять";
                break;
            case 36:
                num = "тридцать шесть";
                break;
            case 37:
                num = "тридцать семь";
                break;
            case 38:
                num = "тридцать восемь";
                break;
            case 39:
                num = "тридцать девять";
                break;
            case 40:
                num = "сорок";
                break;
            default:
                num = "Invalid number";
                break;
        }
        Console.WriteLine(num + " учебных заданий");
    }
    
    public static void Case18(int n)
    {
        if (n < 100 || n > 999) {
            Console.WriteLine("Invalid number");
            return;
        }

        string[] ones = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] tens = { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };

        string result = hundreds[n / 100];
        if (n % 100 != 0) {
            result += " " + tens[(n % 100) / 10 - 1];
        }
        if (n % 10 != 0) {
            result += " " + ones[n % 10];
        }
        
        Console.WriteLine(result);
    }

    public static void Case19(int n)
    {
        string[] mas =
        {
            "год зеленой крысы", "год зеленой коровы", "год зеленого тигра", "год зеленого зайца",
            "год зеленого дракона", "год зеленой змеи", "год зеленой лошади", "год зеленой овцы",
            "год зеленой обезьяны", "год зеленой курицы", "год зеленой собаки", "год зеленой свиньи"
        };
        string[] mas2 =
        {
            "год красного крысы", "год красной коровы", "год красного тигра", "год красного зайца",
            "год красного дракона", "год красной змеи", "год красной лошади", "год красной овцы",
            "год красной обезьяны", "год красной курицы", "год красной собаки", "год красной свиньи"
        };
        string[] mas3 =
        {
            "год желтой крысы", "год желтой коровы", "год желтого тигра", "год желтого зайца", "год желтого дракона",
            "год желтой змеи", "год желтой лошади", "год желтой овцы", "год желтой обезьяны", "год желтой курицы",
            "год желтой собаки", "год желтой свиньи"
        };
        string[] mas4 =
        {
            "год белой крысы", "год белой коровы", "год белого тигра", "год белого зайца", "год белого дракона",
            "год белой змеи", "год белой лошади", "год белой овцы", "год белой обезьяны", "год белой курицы",
            "год белой собаки", "год белой свиньи"
        };
        string[] mas5 =
        {
            "год черной крысы", "год черной коровы", "год черного тигра", "год черного зайца", "год черного дракона",
            "год черной змеи", "год черной лошади", "год черной овцы", "год черной обезьяны", "год черной курицы",
            "год черной собаки", "год черной свиньи"
        };

        if (n % 10 == 0)
        {
            Console.WriteLine(mas[n / 10 - 1]);
        }
        else if (n % 10 == 1)
        {
            Console.WriteLine(mas2[n / 10]);
        }
        else if (n % 10 == 2)
        {
            Console.WriteLine(mas3[n / 10]);
        }
        else if (n % 10 == 3)
        {
            Console.WriteLine(mas4[n / 10]);
        }
        else if (n % 10 == 4)
        {
            Console.WriteLine(mas5[n / 10]);
        }
        else if (n % 10 == 5)
        {
            Console.WriteLine(mas[n / 10]);
        }
        else if (n % 10 == 6)
        {
            Console.WriteLine(mas2[n / 10]);
        }
        else if (n % 10 == 7)
        {
            Console.WriteLine(mas3[n / 10]);
        }
        else if (n % 10 == 8)
        {
            Console.WriteLine(mas4[n / 10]);
        }
        else if (n % 10 == 9)
        {
            Console.WriteLine(mas5[n / 10]);
        }
    }
    
    public static void Case20(int d, int m)
    {
        switch (m)
        {
            case 1:
                switch (d)
                {
                    case 19:
                        Console.WriteLine("Козерог");
                        break;
                    case 20:
                        Console.WriteLine("Водолей");
                        break;
                }
                break;
            case 2:
                switch (d)
                {
                    case 18:
                        Console.WriteLine("Водолей");
                        break;
                    case 19:
                        Console.WriteLine("Рыбы");
                        break;
                }
                break;
            case 3:
                switch (d)
                {
                    case 20:
                        Console.WriteLine("Рыбы");
                        break;
                    case 21:
                        Console.WriteLine("Овен");
                        break;
                }
                break;
            case 4:
                switch (d)
                {
                    case 19:
                        Console.WriteLine("Овен");
                        break;
                    case 20:
                        Console.WriteLine("Телец");
                        break;
                }
                break;
            case 5:
                switch (d)
                {
                    case 20:
                        Console.WriteLine("Телец");
                        break;
                    case 21:
                        Console.WriteLine("Близнецы");
                        break;
                }
                break;
            case 6:
                switch (d)
                {
                    case 21:
                        Console.WriteLine("Близнецы");
                        break;
                    case 22:
                        Console.WriteLine("Рак");
                        break;
                }
                break;
            case 7:
                switch (d)
                {
                    case 22:
                        Console.WriteLine("Рак");
                        break;
                    case 23:
                        Console.WriteLine("Лев");
                        break;
                }
                break;
            case 8:
                switch (d)
                {
                    case 22:
                        Console.WriteLine("Лев");
                        break;
                    case 23:
                        Console.WriteLine("Дева");
                        break;
                }
                break;
            case 9:
                switch (d)
                {
                    case 22:
                        Console.WriteLine("Дева");
                        break;
                    case 23:
                        Console.WriteLine("Весы");
                        break;
                }
                break;
            case 10:
                switch (d)
                {
                    case 22:
                        Console.WriteLine("Весы");
                        break;
                    case 23:
                        Console.WriteLine("Скорпион");
                        break;
                }
                break;
            case 11:
                switch (d)
                {
                    case 22:
                        Console.WriteLine("Скорпион");
                        break;
                    case 23:
                        Console.WriteLine("Стрелец");
                        break;
                }
                break;
            case 12:
                switch (d)
                {
                    case 21:
                        Console.WriteLine("Стрелец");
                        break;
                    case 22:
                        Console.WriteLine("Козерог");
                        break;
                }
                break;
        }
        
    }

}