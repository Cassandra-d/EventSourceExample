using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing;

namespace Console1
{
	[EventSource(Name = "Console1")]
	public sealed class Class1EventSource : EventSource, IClass1EventSource
	{
		private static Common.IBaseEventSource _baseEventSource;
		private static IClass1EventSource _log;

		public static IClass1EventSource Log
		{
			get
			{
				return _log;
			}
		}

		private Class1EventSource() { }

		static Class1EventSource()
		{
			_baseEventSource = Common.BaseEventSource.Log;
			_log = new Class1EventSource();
		}

		[NonEvent]
		public void LogStrt(string message)
		{
			_baseEventSource.LogStrt(message);
		}

		[NonEvent]
		public void LogStpt(string message)
		{
			_baseEventSource.LogStpt(message);
		}

		[Event(1,
			Level = EventLevel.Error,
			Message = "Custom Console1 {0}",
			Keywords = EventKeywords.All)]
		public void MyCustomLogStart(string message)
		{
			WriteEvent(1, message);
		}

		public static class Keywords
		{
			public const EventKeywords All = (EventKeywords)64;
		}
	}
}
