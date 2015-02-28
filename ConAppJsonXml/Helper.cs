using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConAppJsonXml
{
	class Helper
	{
		public void RunOne()
		{
			Console.WriteLine("============");
			Product p1 = new Product("Apple", DateTime.Now, new string[] { "Small" });
			string js = JsonConvert.SerializeObject(p1);

			Product p2 = JsonConvert.DeserializeObject<Product>(js);
			Console.WriteLine(p2);
		}

		public void RunTwo()
		{
			Console.WriteLine("============");
			Console.WriteLine("Ran case 2 ...");
		}

		public void RunThree()
		{
			var myDict = new Dictionary<string, List<Product>>();
			myDict.Add("Apple", new List<Product> { new Product(), new Product() });

		}
	}
}
