using System;
namespace CSharp.NETProblems
{
	public class Program1_3
	{
		public static void Main(string[] args)
		{
			var original = new Order { Id = 1, Customer = "Asha", Items = { "Pen", "Book" } };

			var shallow = original.ShallowCopy();
			shallow.Customer = "Aadhi";
			shallow.Items.Add("Bag");
			Console.WriteLine("After Shallow Edit: "+ original.Id+" "+original.Customer+" "+string.Join(",",original.Items));
			Console.WriteLine("Shallowcopy Items: " + string.Join(",", shallow.Items));
			var deep = original.DeepCopy();
			deep.Customer = "Kabilan";
			deep.Items.Add("Laptop");
			Console.WriteLine("After Deep Edit: " + original.Id + " " + original.Customer + " " + string.Join(",", original.Items));
            Console.WriteLine("DeepCopy Items: " + string.Join(",", deep.Items));
        }

	}
	public class Order
	{
		public int Id;
		public required string Customer;
		public List<string> Items = new();

		public Order ShallowCopy() => (Order)MemberwiseClone();

		public Order DeepCopy()
		{
			var copy = (Order)MemberwiseClone();
			copy.Items=new List<string> (Items);
			return copy;
			
		}
	}

}
