using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
	class Program
	{
		static void Main(string[] args)
		{
			Class2EventSource.Log.LogStpt("trututu");
			Class2EventSource.Log.MyCustomLogStp("boms");
			Console.WriteLine("Press a key:");
			Console.ReadKey();
			Console.WriteLine("Done 2");
		}
	}
}
