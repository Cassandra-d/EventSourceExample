using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
	public interface IClass1EventSource : Common.IBaseEventSource
	{
		void MyCustomLogStart(string message);
	}
}
