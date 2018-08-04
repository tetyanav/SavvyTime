using log4net;

namespace SavvyTime
{
	public class Logger
	{
		public static readonly ILog Log = LogManager.GetLogger(nameof(Logger));
	}
}