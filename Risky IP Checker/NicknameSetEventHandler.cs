using RiskyIPCheckerPlugin;
using Smod2.API;
using Smod2.Events;

namespace Smod.Events
{
	class PlayerJoinHandler : IEventPlayerJoin
	{
		private RiskyIPChecker plugin;

		public PlayerJoinHandler(RiskyIPChecker plugin)
		{
			this.plugin = plugin;
		}

		public void OnPlayerJoin(Player player)
		{
			// IP Risk Checker
			if (plugin.GetConfigBool(RiskyIPChecker.CONFIG_ENABLE_RISKY_CHECKER) || plugin.GetConfigBool(RiskyIPChecker.CONFIG_ENABLE_COUNTRY_RESTRICTIONS))
			{
				string[] userAddress = player.IpAddress.Split(':');
				string endAddress = userAddress[userAddress.Length - 1].Trim();

				foreach (string whitelistIP in plugin.GetConfigList(RiskyIPChecker.CONFIG_IP_WHITELIST))
				{
					string[] whitelistAddress = whitelistIP.Split(':');
					string endWhitelistAddress = (whitelistAddress.Length >= 1 ? whitelistAddress[whitelistAddress.Length - 1] : whitelistIP).Trim();

					if (endAddress.Equals(endWhitelistAddress))
					{
						return; // If IP is whitelisted, don't check it
					}
				}

				this.plugin.ipcheck.Check(player);
			}
			// end
		}
	}
}
