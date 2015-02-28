using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace ConAppJsonXml
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Helper hp = new Helper();
			bool answer = true;
			while (answer)
			{
				Console.Write("Enter command number: ");
				int cmd = 0;
				bool res = Int32.TryParse(Console.ReadLine(), out cmd);

				switch (cmd)
				{
					case 1:
						hp.RunOne();
						break;
					case 2:
						hp.RunTwo();
						break;
					default:
						Console.WriteLine("Wrong command... Exiting");
						break;
				}

				Console.Write("Again? [y/n] ");
				string resp = Console.ReadLine();

				//Keep telling me "wrong choice" till resp "y" or resp "n"
				while (!(resp.Contains("y")))
				{
					if (resp.Contains("n"))
					{
						break;
					}
					else
					{
						Console.Write("Wrong answer [y/n] only ... ");
						resp = Console.ReadLine();
					}	
				}
				
				if (resp == "n")
				{
					Console.WriteLine("Exiting app ...");
					answer = false;
				}
				else
				{
					Console.Clear();
					continue;
				}
			}
		}
	}
}
