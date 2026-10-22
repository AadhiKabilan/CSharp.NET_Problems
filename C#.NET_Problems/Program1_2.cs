using System;
namespace CSharp.NETProblems
{
    class Program1_2
    {
        public static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            int[] y = { 7, 8, 9 };
            Console.WriteLine(string.Join(",", x));
            Console.WriteLine(string.Join(",", y));
            SwapNoRef( x,  y);
            Console.WriteLine("No Ref Swap");
            Console.WriteLine(string.Join(",", x));
            Console.WriteLine(string.Join(",", y));
            SwapWithRef(ref x, ref y);
            Console.WriteLine("Swap with Ref");
            Console.WriteLine(string.Join(",", x));
            Console.WriteLine(string.Join(",", y));
            SwapFirst( x, y);
            Console.WriteLine("Swap First");
            Console.WriteLine(string.Join(",", x));
            Console.WriteLine(string.Join(",", y));
        }
        public static void SwapNoRef(int[] a, int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        public static void SwapWithRef(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        public static void SwapFirst(int[] a, int[] b)
        {
            int temp = a[0];
            a[0] = b[0];
            b[0] = temp;

        }
    }

}