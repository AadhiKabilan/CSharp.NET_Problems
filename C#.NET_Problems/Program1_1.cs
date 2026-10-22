using System;
namespace CSharp.NETProblems
{
	class Program1_1
	{
		public static void Main(string[] args)
		{
			var s = new PointS { x=1, y=2 };
			var c = new PointC { x=1, y=2 };

            Console.WriteLine("Before-> struct: " +s.x +" "+ s.y+" "+"class: "+c.x+" "+c.y);
            
			MoveS(s);
            MoveC(c);
            
			Console.WriteLine("After-> struct: " + s.x + " " + s.y + " " + "class: " + c.x + " " + c.y);

            var s1 = s;	s1.y = 99;
			var c1 = c;	c1.y = 99;
			
			Console.WriteLine("Assign  -> s.y = " + s.y + " c.y = " + c.y);

        }
		public struct PointS
		{
			public int x; public int y;
		}
		public class PointC
		{
			public int x; public int y;
		}
		static void MoveS(PointS p)
		{
			p.x += 10;
		}
		static void MoveC(PointC p)
		{
			p.x += 10;
		}
	}
}
