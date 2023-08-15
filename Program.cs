using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace addtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void main()
            {

            }
            string a = Console.ReadLine();
            string t = Console.ReadLine();
            a=dx(a);
            t=dx(t);
            int [] na = new int[a.Length >= t.Length ? a.Length : t.Length];
            int [] nt = new int[a.Length >= t.Length ? a.Length : t.Length];
            int [] an = new int[(a.Length>=t.Length? a.Length: t.Length)+1];
            input();
            add();
            output();

             string dx(string d)//倒序
             {
                    char[] charArray = d.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
             }

            void input()//将字符串写入数组
            {
                for (int i = 0; i < a.Length; i++)
                {
                    na[i] = zh(a[i]);
                }
                for (int i = 0;i < t.Length; i++)
                {
                    nt[i] = zh(t[i]);
                }
            }

            int zh(char sz)//用Switch-case将char转换为int
            {
                int r = 0;
                switch (sz)
                {
                    case '0':
                        r = 0;
                        break;
                    case '1':
                        r = 1;
                        break;
                    case '2':
                        r = 2;
                        break;
                    case '3':
                        r = 3;
                        break;
                    case '4':
                        r = 4;
                        break;
                    case '5':
                        r = 5;
                        break;
                    case '6':
                        r = 6;
                        break;
                    case '7':
                        r = 7;
                        break;
                    case '8':
                        r = 8;
                        break;
                    case '9':
                        r = 9;
                        break;
                    default:
                        break;
                }
                return r;
            }

            void add()//进行加法计算
            {
                for(int i = 0; i<na.Length;i++)
                {
                    an[i] = na[i] + nt[i];
                }
            }

            void output()
            {
                for (int i = 0; i < na.Length; i++)
                {
                    while (an[i]>=10)
                    {
                        an[i + 1] += 1;
                        an[i] -= 10;
                    }
                }
                Array.Reverse(an);
                foreach (var item in an)
                {
                    Console.Write(item);
                }
            }
            Console.ReadLine();
        }
    }
}
