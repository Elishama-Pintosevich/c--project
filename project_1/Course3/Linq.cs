using System.Linq;
namespace HelloWorld.Course3
{
	public class Linq
	{
		public static void test()
		{
			var myList = new List<int> { 20,30,200,300,2000,3000 };
			var smallNumbers = myList.Where(i => i < 3000);

			foreach (var item in smallNumbers)
			{
				Console.WriteLine(item);
			}
		}
	}
}

