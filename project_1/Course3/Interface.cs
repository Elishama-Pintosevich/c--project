using System;
namespace HelloWorld.Course3
{
    public interface Ilogger
    {
        void LogMessage(string message);
        void LogError(string error);
    }
    public interface Itest
    {
        void SuperTest(string txt);
    }

    public class Interface : Ilogger, Itest
	{
        public void LogMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void LogError(string error)
        {
            Console.WriteLine($"Error: {error}");
        }
        public void SuperTest(string txt)
        {
            Console.WriteLine(txt + "boom");
        }

    }
}

