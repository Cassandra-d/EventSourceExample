using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Diagnostics.Tracing;

namespace Console1
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1EventSource.Log.LogStrt("bla bla bla 1");
			Class1EventSource.Log.MyCustomLogStart("lululu");
			Console.WriteLine("Press a key:");
			Console.ReadKey();
			Console.WriteLine("Done 1");
		}
	}
	
}
