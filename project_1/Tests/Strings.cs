using System;
namespace HelloWorld.Tests
{
	public class Strings
	{
		static public void test()
		{
			var firstName = "eli";
			var lastName = "pinto";
			string str = string.Format("{0} {1}", firstName, lastName);
			Console.WriteLine(str);
		}
		static public void test1()
		{
			var numbers = new int[3] { 1, 2, 3 };
			string list = string.Join(",", numbers);
            Console.WriteLine(list);
        }
        static public void test2()
        {
			var firstName = "eli";
			char letter = firstName[0];
			var path = "user\\eli";
			var path2 = @"user\eli";
        }

    }
}

