using System.Collections.Generic;
namespace HelloWorld.Course2
{
	public class Customer
	{
		public int id;
		public string name;
		public List<Order> orders;

		public Customer()
		{
			orders = new List<Order>();
		}
		public Customer(int id)
			:this()
		{
			this.id = id;
		}
		public Customer(int id, string name)
			:this(id)
		{
			this.name = name;
		}
	}
}

