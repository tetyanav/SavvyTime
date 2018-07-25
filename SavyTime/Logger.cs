using log4net;

namespace SavyTime
{
	public class Logger
	{
		public static readonly ILog Log = LogManager.GetLogger(nameof(Logger));
	}
}