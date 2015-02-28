using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppLinqToXml
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Helper hp = new Helper(); 
			hp.RunOne("People.xml");
			Console.ReadLine();
		}
	}
}
