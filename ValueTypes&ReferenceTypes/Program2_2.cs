using System;
using System.Runtime.CompilerServices;
namespace ValueTypes {
	public class Program2_2
	{
		public static void Main(string[] args)
		{
			object boxed = 42;
			try { long l = (long)boxed; Console.Write(l); }
			catch (InvalidCastException ex) { Console.WriteLine($"(long)boxedInt -> {ex.GetType().Name}"); }

            Console.WriteLine($"(long)(int)boxed -> {(long)(int)boxed}");
        }
	}
}