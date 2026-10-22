using System;
using System.Collections;
using System.Diagnostics;
namespace CSharp.NETProblems
{
	public class Program2_1
	{
		public static void Main(string[] args)
		{
			int n= 5000000;
			
			//ArrayList
			long before = GC.GetAllocatedBytesForCurrentThread();
			var sw = Stopwatch.StartNew();
			var al = new ArrayList();
			for (int i = 1; i <= n; i++)
			{
				al.Add(i);
			}
			long sum1 = 0;
			foreach (object o in al)
			{
				sum1 += (int)o;
			}
            sw.Stop();
			long bytes = GC.GetAllocatedBytesForCurrentThread() - before;
            double mb = bytes / (1024.0 * 1024.0);
			Console.WriteLine($"ArrayList: sum = {sum1} time = {sw.ElapsedMilliseconds} ms  Allocation size= {mb}");

            //List<int>
            before = GC.GetAllocatedBytesForCurrentThread();
			sw.Restart();
			var ls = new List<int>();
			for (int i = 1; i <= n; i++)
			{
				ls.Add(i);
			}
			sum1 = 0;
			foreach (object o in ls)
			{
				sum1 += (int)o;
			}
			sw.Stop();
            bytes = GC.GetAllocatedBytesForCurrentThread() - before;
            mb = bytes / (1024.0 * 1024.0);
            Console.WriteLine($"List<int>: sum = {sum1} time = {sw.ElapsedMilliseconds} ms  Allocation size= {mb}");


        }
    }
}