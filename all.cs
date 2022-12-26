using System;

class Program
{
    static string long_math(string n1, string n2)
    {
        string res = "";
        int min_l = n1.Length;
        bool nxt = false;
        if (n1.Length > n2.Length) min_l = n2.Length;
        for (int i = min_l - 1; i >= 0; i--)
        {
            int o = Convert.ToInt32(Convert.ToString(n1[n1.Length - i - 1])) + Convert.ToInt32(Convert.ToString(n2[n2.Length - i - 1]));
            if (o <= 9)
            {
                if (nxt) o++;
                res += Convert.ToString(o);
                nxt = false;
            }
            else
            {
              if (nxt) o++;
                res += Convert.ToString(o-10);
                nxt = true;
            }
            
          }
      // 99+1
      string res2 = "";
      if (n1.Length != n2.Length){
            if (min_l == n1.Length) {
              int index = n1.Length -1;
              res2= n1.Remove(index,  n2.Length-index);
              
              }
      else{
              int index = n2.Length -1;
              res2= n1.Remove(index,  n1.Length-index);
              
      }
        }
        
        return res2+ res;
    }
    public static void Main()
    {
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        Console.WriteLine($"{n1}+{n2}={long_math(n1, n2)}");
    }
}
