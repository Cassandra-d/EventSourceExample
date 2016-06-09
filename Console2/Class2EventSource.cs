using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing;

namespace Console2
{
	[EventSource(Name = "Console2")]
	public sealed class  Class2EventSource : EventSource, IClass2EventSource
	{
		private static Common.IBaseEventSource _baseEventSource;
		private static IClass2EventSource _log;

		public static IClass2EventSource Log
		{
			get
			{
				return _log;
			}
		}

		private Class2EventSource() { }

		static Class2EventSource()
		{
			_baseEventSource = Common.BaseEventSource.Log;
			_log = new Class2EventSource();
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
			Message = "Custom Console2 {0}",
			Keywords = EventKeywords.All)]
		public void MyCustomLogStp(string message)
		{
			WriteEvent(1, message);
		}

		public static class Keywords
		{
			public const EventKeywords All = (EventKeywords)128;
		}
	}
}
