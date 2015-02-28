using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppLinqToXml
{
	public class Person: IPrintable
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Job { get; set; }

		public Person(int id, string name, int age, string job)
		{
			ID = id;
			Name = name;
			Age = age;
			Job = job;
		}

		public override string ToString()
		{
			return this.GetType().Name + "\n" + this.GetType().Module;
		}
	
		public string Print(string message)
		{
			return String.Format("ID:{0}\nName:{1}\nAge:{2}\nJob:{3}",
				ID, Name, Age, Job);
		}


		public string Print()
		{
			return String.Format("ID: {0}\nName: {1}\nAge: {2}\nJob: {3}",
				ID, Name, Age, Job);
		}
	}
}