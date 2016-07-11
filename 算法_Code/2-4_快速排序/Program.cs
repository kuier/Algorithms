using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_快速排序
{
    class Program
    {
        class QuickSort
        {
            public static void Sort(int[] a)
            {
                Sort(a,0,a.Length-1);
            }

            private static void Sort(int[] a, int lo, int hi)
            {
                if (lo >= hi)
                {
                    return;
                }
                int j = Partition(a, lo, hi);
                Sort(a, lo, j - 1);
                Sort(a, j + 1, hi);

            }

            private static int Partition(int[] a, int lo, int hi)
            {
                int i = lo, j = hi + 1;
                int v = a[lo];
                while (true)
                {
                    while (Less(a[++i], v))
                    {
                        if (i == hi)
                        {
                            break;
                        }
                    }
                    while (Less(v, a[--j]))
                    {
                        if (j == lo)
                        {
                            break;
                        }
                    }
                    if (i >= j)
                    {
                        break;
                    }
                    Exch(a, i, j);
                }
                Exch(a, lo, j);
                return j;
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
            QuickSort.Sort(a);
            QuickSort.Show(a);
        }
    }
}
