using System.Collections.Generic;

namespace HelloWorld.Tests
{
	public class Lists
	{
        static public void test()
        {
            var numbers = new List<int>() { 1,2,3};
            numbers.Add(4);
            var arr = new[] { 8, 9, 10 };
            numbers.AddRange(arr);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            var length = numbers.Count;

        }
    }
}

