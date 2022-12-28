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
        int o = 0;
        string check = "";
        while (n1.Length != n2.Length)
        {
            check += "0";
            n2 = check + n2;
        }
    }
    static void l_m_pls(string n1, string n2)
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
        Console.WriteLine(res);
        
    }
    public static void Main()
    {
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        l_m_pls(n1, n2);
    }
}
