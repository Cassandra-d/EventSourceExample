using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
	public interface IClass2EventSource : Common.IBaseEventSource
	{
		void MyCustomLogStp(string message);
	}
}
