using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppJsonXml
{
	class Product
	{
		public string ProdName { get; set; }
		public DateTime Expiry { get; set; }
		public string[] Sizes { get; set; }

		public Product(string pn, DateTime dt, string[] se)
		{
			ProdName = pn;
			Expiry = dt;
			Sizes = se;
		}

		public Product() { }

		public override string ToString()
		{
			return String.Format("Name: {0}\nEx Date: {1}\nSizes: {2}",
				ProdName, Expiry, Sizes[0]);
		}
	}
}
