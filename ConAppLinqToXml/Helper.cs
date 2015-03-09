using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConAppLinqToXml
{
	class Helper
	{
		private string location = String.Empty;

		public string Location 
		{
			get { return location; }
			set { location = value; }
		}
		
		public void RunOne(string fileName)
		{
			Location = ConfigurationManager.AppSettings["location"];
			XDocument myDoc = XDocument.Load(Location+fileName);

			//query
			var names = (from rec in myDoc.Descendants("Person")
								let id = int.Parse(rec.Attribute("id").Value)
								select new Person(id, rec.Element("Name").Value,
								int.Parse(rec.Element("Age").Value), rec.Element("Job").Value)).ToList();
			
			//displaying results in console application
			foreach (var item in names)
			{
				Console.WriteLine(item.Print());
				Console.WriteLine();
			}
		}
	}
}
