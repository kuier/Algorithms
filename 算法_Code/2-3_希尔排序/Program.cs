using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_希尔排序
{
    class Program
    {
        public class Shell
        {
            public static void Sort(int[] a)
            {
                int n = a.Length;
                int h = 1;
                while (h<n/3)
                {
                    h = 3*h + 1;
                }
                //这个地方初始i = h。不是i= 0；
                while (h>=1)
                {
                    for (int i = h; i < n; i++)
                    {
                        // j-=h，不是j--
                        for (int j = i; j >= h; j -= h)
                        {
                            if (Less(a[j], a[j - h]))
                            {
                                Exch(a, j, j - h);
                            }
                        }
                    }
                    h = h/3;
                }
            }
            private static bool Less(int a, int b)
            {
                return a < b;
            }

            private static void Exch(int[] a, int i, int j)
            {
                int temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }

            public static void Show(int[] a)
            {
                foreach (var i in a)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int[] a = new[] { 5, 8, 7, 4, 1, 2, 9, 3, 6 };
            Shell.Sort(a);
            Shell.Show(a);

        }
    }
}
