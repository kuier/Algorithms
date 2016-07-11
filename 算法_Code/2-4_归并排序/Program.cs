using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_归并排序
{
    class Program
    {
        public class MergeSort
        {
            private static int[] aux;
            public static void Sort(int[] a)
            {
                aux = new int[a.Length];
                Sort(a,0,a.Length-1);
            }

            public static void SortBU(int[] a)
            {
                int n = a.Length;
                aux = new int[n];
                for (int len = 1; len < n; len *=2)
                {
                    for (int lo = 0; lo < n-len; lo+=len+len)
                    {
                        int mid = lo + len - 1;
                        int hi = Math.Min(lo + len + len - 1, n - 1);
                        Merge(a,lo,mid,hi);
                    }
                }
            }
            private static void Sort(int[] a, int lo, int hi)
            {
                if (lo >= hi)
                {
                    return;
                }
                int mid = lo + (hi - lo)/2;
                Sort(a, lo, mid);
                Sort(a, mid + 1, hi);
                Merge(a,lo,mid,hi);
            }
            public static void Merge(int[] a, int lo, int mid, int hi)
            {
                int i = lo;
                int j = mid + 1;
                for (int k = 0; k < a.Length; k++)
                {
                    aux[k] = a[k];

                }
                for (int k = lo; k <=hi; k++)
                {
                    //左半边用尽，取右半边元素
                    if (i>mid)
                    {
                        a[k] = aux[j++];
                    }
                    //右半边用尽，取左半边元素
                    else if (j>hi)
                    {
                        a[k] = aux[i++];
                    }
                    //左边元素大于右边，取右半边
                    else if (Less(aux[j],aux[i]))
                    {
                        a[k] = aux[j++];
                    }
                    else
                    {
                        a[k] = aux[i++];
                    }
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
            MergeSort.SortBU(a);
            MergeSort.Show(a);

        }
    }
}
