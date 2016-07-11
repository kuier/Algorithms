using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_插入排序
{
    class Program
    {
        public class InsertSort
        {
            public static void Sort(int[] a)
            {
                for (int i = 1; i < a.Length; i++)
                {
                    for (int j = i; j >0; j--)
                    {
                        //这个地方比较的是a[j]和a[j-1]
                        if (Less(a[j],a[j-1]))
                        {
                            Exch(a,j,j-1);
                        }
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
            InsertSort.Sort(a);
            InsertSort.Show(a);
        }
    }
}
