using System;
namespace HelloWorld.Tests
{
	public class Arrays
	{
		static public void test()
		{
			int[] arr = new int[3] { 3, 4, 5 };
            var arr2 = new int[3] { 3, 4, 5 };
            Console.WriteLine("length: "+arr.Length);
		}
        static public void test2()
        {
            var matrix = new int[2, 2];
            var jagged = new int[2][];
            jagged[0] = new int[5];
        }
        static public void test3()
        {
            var numbers = new int[3] { 99, 43, 67 };
            var copyNumbers = new int[3];
            Array.Copy(numbers, copyNumbers, numbers.Length);
            foreach (var number in copyNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

