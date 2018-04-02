using RiskyIPCheckerPlugin;
using Smod2.API;
using Smod2.Events;

namespace Smod.Events
{
	class RoundStartHandler : IEventRoundStart
	{
		private RiskyIPChecker plugin;

		public RoundStartHandler(RiskyIPChecker plugin)
		{
			this.plugin = plugin;
		}

		public void OnRoundStart(Server server)
		{
			// IP Risk Checker
			if (this.plugin.ipcheck.smCurUpdateCount <= 0)
			{
				this.plugin.ipcheck.smCurUpdateCount = this.plugin.ipcheck.smUpdateIPTrustEvery;
				this.plugin.ipcheck.smIPTrust.Clear();
			}
			else
			{
				this.plugin.ipcheck.smCurUpdateCount--;
			}
			// end
		}
	}
}
