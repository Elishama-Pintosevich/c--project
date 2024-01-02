using System;
namespace HelloWorld.Course2
{
	public class Customer2
	{
		public int id;
		public string name;
		public readonly List<Order> orders = new List<Order>();

        
        public Customer2(int id)
        {
            this.id = id;
        }
        public Customer2(int id, string name)
            : this(id)
        {
            this.name = name;
        }
        public void promote()
        {

        }
    }
}

