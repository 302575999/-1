using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        class Yunsuan
        {
            private string shu1;
            private string shu2;
            public string Shu1 { get => shu1; set => shu1 = value; }
            public string Shu2 { get => shu2; set => shu2 = value; }
            public void Shuru()
            {
                try
                {
                    Console.WriteLine("请输入第一串字符:");
                    shu1 = Console.ReadLine();
                    Console.WriteLine("请输入第二串字符:");
                    shu2 = Console.ReadLine();
                    Console.WriteLine("请输入运算符：");
                    string operate = Console.ReadLine();
                    switch (operate)
                    {
                        case "+":
                            Jia();
                            break;
                        case "-":
                            Jian();
                            break;
                        case "*":
                            Cheng();
                            break;
                        case "/":
                            Chu();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入有误，重新输入！");
                }
            }
            private void Jia()
            {
                bool key = false;
                if(shu1.Length>shu2.Length)
                {
                    for (int i = 0; i < shu1.Length; i++)
                    {
                        if (!Char.IsNumber(shu1, i))
                            key = true;
                    }
                }
                else
                {
                    for (int i = 0; i < shu2.Length; i++)
                    {
                        if (!Char.IsNumber(shu2, i))
                            key = true;
                    }
                }
                if (key)
                    Console.WriteLine("结果为:{0}", Shu1 + Shu2);
                else
                {
                    float Shu1 = float.Parse(shu1);
                    float Shu2 = float.Parse(shu2);
                    Console.WriteLine("结果为:{0}", Shu1 + Shu2);
                }
            }
            private void Jian()
            {
                bool key = false;
                if (shu1.Length > shu2.Length)
                {
                    for (int i = 0; i < shu1.Length; i++)
                    {
                        if (!Char.IsNumber(shu1, i))
                            key = true;
                    }
                }
                else
                {
                    for (int i = 0; i < shu2.Length; i++)
                    {
                        if (!Char.IsNumber(shu2, i))
                            key = true;
                    }
                }
                if (key == true)
                {
                    string r = null;
                    char[] aa = shu1.ToCharArray();
                    char[] bb = shu2.ToCharArray();
                    List<char> L = new List<char>();
                    for (int k = 0; k < aa.Length; k++)
                    {
                        L.Add(aa[k]);
                    }
                    for (int i = 0; i < bb.Length; i++)
                    {
                        for (int j = 0; j < aa.Length; j++)
                        {
                            if (bb[i] == aa[j])
                            {
                                L.Remove(aa[j]);
                            }
                        }
                    }
                    foreach (char c in L)
                    {
                        r = r + c;
                    }
                    Console.WriteLine("结果为:{0}", r);
                }
                else
                {
                    float Shu1 = float.Parse(shu1);
                    float Shu2 = float.Parse(shu2);
                    Console.WriteLine("结果为:{0}", Shu1 - Shu2);
                }
            }
            private void Cheng()
            {
                float Shu1 = float.Parse(shu1);
                float Shu2 = float.Parse(shu2);
                Console.WriteLine("结果为:{0}", Shu1 * Shu2);
            }
            private void Chu()
            {
                float Shu1 = float.Parse(shu1);
                float Shu2 = float.Parse(shu2);
                Console.WriteLine("结果为:{0}", Shu1 / Shu2);
            }
            public void Equals()
            {
                if (Shu1 == Shu2)
                    Console.WriteLine("相等");
                else
                    Console.WriteLine("不相等");
            }
        }
        static void Main(string[] args)
        {

            Yunsuan ss1 = new Yunsuan();
            ss1.Shuru();
            ss1.Equals();
        }
    }
}
