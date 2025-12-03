using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //string str = Console.ReadLine();
            //int num = int.Parse(str);
            //num += 100;
            //Console.WriteLine(num);

            ////2
            //double rd = (double)(7 / 2);
            //int ld = (int)(7.0 / 2);
            //if (rd > (double)ld)
            //{
            //    Console.WriteLine("Первое больше");
            //}
            //else if (rd == (double)ld)
            //{
            //    Console.WriteLine("Равны");
            //}
            //else
            //{
            //    Console.WriteLine("Второе больше");
            //}
            ////Они равны.
            ////Первое число - это перевод целового числа 3 в double и выходит 3.0, т. е. ровно 3.
            ////Второе число - перевод дробного числа 3.5 в int и .5 отсекается. Выходит тоже 3.

            ////3
            //string str2 = Console.ReadLine();
            //if (int.TryParse(str2, out int num2))
            //{
            //    Console.WriteLine(num2 * num2);
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка вывода");
            //}

            ////4
            //double h = double.Parse(Console.ReadLine());
            //int k = (int)h;
            //Console.WriteLine(h - (double)k);

            ////5
            //int[] o = new int[5];
            //for (int i = 0; i < o.Length; i++)
            //{
            //    o[i] = int.Parse(Console.ReadLine());
            //}
            //string str3 = "";
            //for (int i = 0; i < o.Length; i++)
            //{
            //    str3 += o[i].ToString();
            //}
            //Console.WriteLine(str3);

            ////6
            //int g = 0;
            //for (int i = 0; i < o.Length; i++)
            //{
            //    if (o[i] % 2 == 0)
            //    {
            //        g++;
            //    }
            //}
            //Console.WriteLine(g);

            ////7
            //int y = 0;
            //for (int i = 0; i < o.Length; i++)
            //{
            //    y += o[i];
            //}
            //Console.WriteLine($"{y} {(double)y / o.Length}");

            ////8
            //int[] c = new int[5];
            //c = o;
            //int temp;
            //temp = c[0];
            //c[0] = c[c.Length - 1];
            //c[c.Length - 1] = temp;
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}

            ////9

            //int[] t = new int[5];
            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = int.Parse(Console.ReadLine());
            //}
            //int min = t[0];
            //int max = t[0];
            //int indexMax = 0;
            //int indexMin = 0;
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[i] < min)
            //    {
            //        min = t[i];
            //        indexMin = i;
            //    }
            //    if (t[i] > max)
            //    {
            //        max = t[i];
            //        indexMax = i;
            //    }
            //}
            //Console.WriteLine($"{min} {indexMin} {max} {indexMax}");



            ////10
            //int[] j = new int[10];
            //int count = 5;
            //for (int i = 0; i < count; i++)
            //{
            //    j[i] = int.Parse(Console.ReadLine());
            //}
            //int sd = int.Parse(Console.ReadLine());
            //if (j.Length > count)
            //{
            //    j[count] = sd;
            //}
            //else
            //{
            //    int[] ty = new int[j.Length * 2];
            //    for (int i = 0; i < j.Length; i++)
            //    {
            //        ty[i] = j[i];
            //    }
            //    j = ty;
            //}
            //for (int i = 0; i < j.Length; i++)
            //{
            //    Console.WriteLine(j[i]);
            //}

            ////11
            //int[] idf = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idf[i] = int.Parse(Console.ReadLine());
            //}
            //int fd = int.Parse(Console.ReadLine());
            //for (int i = fd+1;  i < idf.Length; i++)
            //{
            //    idf[i - 1] = idf[i];
            //}
            //idf[idf.Length - 1] = 0;
            //for(int i = 0;i<idf.Length; i++)
            //{
            //    Console.WriteLine(idf[i]);
            //}

            ////12
            //int[] idf = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idf[i] = int.Parse(Console.ReadLine());
            //}
            //int fd = int.Parse(Console.ReadLine());
            //idf[fd] = idf[idf.Length - 1];
            //idf[idf.Length - 1] = 0;
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    Console.WriteLine(idf[i]);
            //}

            ////13
            //int[] idf = new int[5];
            //int temp;
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idf[i] = int.Parse(Console.ReadLine());
            //}
            //int fd = int.Parse(Console.ReadLine());
            //for (int k = 0; k < idf.Length; k++)
            //{
            //    for (int i = 0; i < idf.Length - 1; i++)
            //    {
            //        if (fd == idf[i])
            //        {
            //            temp = idf[i];
            //            idf[i] = idf[i + 1];
            //            idf[i + 1] = temp;

            //        }
            //    }
            //    idf[idf.Length - 1] = 0;
            //}

            //for (int i = 0; i < idf.Length; i++)
            //{
            //    Console.WriteLine(idf[i]);
            //}

            ////14
            //int[] idf = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idf[i] = int.Parse(Console.ReadLine());
            //}
            //int[] idk = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idk[i] = idf[idf.Length-1-i];
            //}
            //for (int i = 0; i < idk.Length; i++)
            //{
            //    Console.WriteLine(idk[i]);
            //}

            ////15
            //int[] idf = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idf[i] = int.Parse(Console.ReadLine());
            //}
            //int[] idk = new int[5];
            //for (int i = 0; i < idf.Length; i++)
            //{
            //    idk[i] = idf[idf.Length - 1 - i];
            //}
            //int hf = 1;
            //for (int i = 0; i < idk.Length; i++)
            //{
            //    if (idk[i] == idf[i])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        hf = 0;
            //    }
            //}
            //if (hf == 1)
            //{
            //    Console.WriteLine("Палиндром");
            //} else
            //{
            //    Console.WriteLine("Не палиндром");
            //}

            ////16
            //int[] ju = new int[10];
            //for (int i = 0; i < ju.Length; i++)
            //{
            //    ju[i] = int.Parse(Console.ReadLine());
            //}
            //for (int y = 0; y < ju.Length; y++)
            //{
            //    for (int i = 0; i < ju.Length - 2; i++)
            //    {
            //        if (ju[i] == ju[i + 1])
            //        {
            //            for (int j = i + 1; j < ju.Length - 1; j++)
            //            {
            //                ju[j] = ju[j + 1];
            //            }
            //            ju[ju.Length - 1] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < ju.Length; i++)
            //{
            //    Console.WriteLine(ju[i]);
            //}




        }


    }
}
