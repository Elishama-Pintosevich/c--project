using System;
namespace HelloWorld.Tests
{
	public class Iterations
	{
        static public void test()
        {
            var numbers = new int[3] { 1, 2, 3 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

