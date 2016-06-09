using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public interface IBaseEventSource
	{
		void LogStrt(string message);
		void LogStpt(string message);
	}
}
