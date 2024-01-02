using System;
namespace HelloWorld.Course3
{
	public class Lambda
	{
		public static void test(int x, int z)
		{
			Func<int, int, int> func = (x, z) => x * z;
			Console.WriteLine(func(x, z));
		}
		public static void test2()
		{
			var myList = new List<int> { 20, 30, 200, 300, 2000, 3000 };
			var filterList = myList.FindAll(item => item < 1000);

			foreach (var item in filterList)
			{
				Console.WriteLine(item);
			}
		}
	}
}

