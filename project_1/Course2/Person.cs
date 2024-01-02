using System;
namespace HelloWorld.Course2
{
	public class Person
	{
        //property means that its same like public but public will be only get but not set
        public int Id { get; private set; }
        public int Age
        {
            get { return Age + 10; }
            set { Age = value; }
        }
        private string _name;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
    }
}

