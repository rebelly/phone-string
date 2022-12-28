using System;

class Program
{
    static string reverse_string( string n1)
    {
        string res = "";
        for (int i = n1.Length-1; i > -1; i--) { 

            res += n1[i];
        }
        return res;
    }
    static void same_lenth(string n1, ref string n2)
    {

        while (n1.Length > n2.Length)
        {
            
            n2 = "0" + n2;
            
        }
    }
    static string l_m_pls(string n1, string n2)
    {

        if (n1.Length <= n2.Length)
        {
            string temp = n1;
            n1 = n2;
            n2 = temp;
            
        }
        same_lenth(n1, ref n2);
        string res = "";
        int cur;
        bool nxt = false;
        for (int i = n1.Length-1; i > -1; i--)
        {
            {
                cur = Convert.ToInt32(Convert.ToInt32(n1[i]) - 48 + Convert.ToInt32(n2[i]) - 48);
                if (nxt)
                {
                    cur++;
                    nxt = false;
                }
                if (cur < 10)
                {
                    res += cur;
                }
                else
                {
                    
                    cur -= 10;
                    res += cur;
                    nxt = true;
                }
            }
        }
        res = reverse_string(res);
        if (nxt)
        {
            if (res.Length == n1.Length)
            {
                res = "1" + res;

            }
            else res = Convert.ToString(Convert.ToInt32(res[0]) - 48);
        }
        return res;
        
    }
    static string l_m_minus(string n1, string n2)
    {
        bool min = true;
        if (n1.Length > n2.Length && n1[0] > n2[0]) min = false;
        else
        {
            string temp = n1;
            n1 = n2;
            n2 = temp;

        }
        same_lenth(n1, ref n2);
        int cur;
        string res = "";
        bool nxt = false;
        for (int i = n1.Length-1; i > -1; i--)
        {
            {
                cur = Convert.ToInt32((Convert.ToInt32(n1[i]) - 48) - (Convert.ToInt32(n2[i]) - 48));
                if (nxt)
                {
                    cur--;
                    nxt = false;
                }
                if (cur >= 0)
                {
                    res += cur;
                }
                else
                {
                    
                    cur += 10;
                    res += cur;
                    nxt = true;
                }
            }
        }
        res = reverse_string(res);
        if (min) res = "-" + res;
        return res;
    }
    public static void Main()
    {
        Console.WriteLine("Введите первое число");
        string n1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string n2 = Console.ReadLine();
        Console.WriteLine("Введите знак записанный между числами");
        string sign = Console.ReadLine();
        if (sign == "+")
        {
            Console.WriteLine($"{n1} + {n2} = {l_m_pls(n1, n2)}");
        }
        else if(sign == "-")
        {
            Console.WriteLine($"{n1} - {n2} = {l_m_minus(n1, n2)}");
        }
        else
        {
            Console.WriteLine("Неизвестный знак, Введите либо '+' либо '-' ");
        }
    }
}
