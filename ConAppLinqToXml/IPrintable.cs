using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppLinqToXml
{
	public interface IPrintable
	{
		string Print(string message);
		string Print();
	}
}
