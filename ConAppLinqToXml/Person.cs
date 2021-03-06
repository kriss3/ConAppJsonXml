﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppLinqToXml
{
	/// <summary>
	/// Business obejct -> Person class to represesnt entity created from the xml file
	/// </summary>
	public class Person: IPrintable
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Job { get; set; }


		/// <summary>
		/// Constractors -> remember that ID can be replaced
		/// with autogenerated guids
		/// </summary>
		/// <param name="id">ID of a person</param>
		/// <param name="name">Name</param>
		/// <param name="age">Age</param>
		/// <param name="job">Job name</param>
		public Person(int id, string name, int age, string job)
		{
			ID = id;
			Name = name;
			Age = age;
			Job = job;
		}

		//this is for presentation purposes only - for presentation use Interface
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