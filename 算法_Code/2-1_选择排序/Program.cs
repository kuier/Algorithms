using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_选择排序
{
    internal class Program
    {
        public class SelectSort
        {
            public static void Sort(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    int min = i;
                    //这个地方，j要从i的下一个开始判断。。错误过一次
                    for (int j = i+1; j < a.Length; j++)
                    {
                        if (Less(a[j],a[min]))
                        {
                            min = j;
                        }
                    }
                    Exch(a,i,min);
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
            int[] a = new[] {5, 8, 7, 4, 1, 2, 9, 3, 6};
            SelectSort.Sort(a);
            SelectSort.Show(a);
        }
    }
}
