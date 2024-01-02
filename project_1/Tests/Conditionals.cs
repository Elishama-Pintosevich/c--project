using System;
namespace HelloWorld.Tests
{
	public class Conditionals
	{
		static public void test()
		{
			var isTrue = false;
			int price = isTrue ? 10 : 15;
			Console.WriteLine(price);
		}
        static public void test2()
        {
			var input = "else";
            switch (input)
			{
				case "eli":
					Console.WriteLine("nice");
					break;
				case "else":
					Console.WriteLine("bad");
					break;
				default:
					Console.WriteLine("goo");
					break;

			}
        }
    }
}

