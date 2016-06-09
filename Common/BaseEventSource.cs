using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing;

namespace Common
{
	[EventSource(Name = "BaseES")]
	public sealed class BaseEventSource : EventSource, IBaseEventSource
	{
		static BaseEventSource _log;

		public static BaseEventSource Log
		{
			get
			{
				return _log;
			}
		}

		private BaseEventSource() { }

		static BaseEventSource()
		{
			_log = new BaseEventSource();
		}

		[Event(1,
			Level = EventLevel.Error,
			Message = "Base strt {0}",
			Keywords = EventKeywords.All)]
		public void LogStrt(string message)
		{
			WriteEvent(1, message);
		}

		[Event(2,
			Level = EventLevel.Error,
			Message = "Base stp {0}",
			Keywords = EventKeywords.All)]
		public void LogStpt(string message)
		{
			WriteEvent(2, message);
		}

		public static class Keywords
		{
			public const EventKeywords All = (EventKeywords)32;
		}
	}
}
