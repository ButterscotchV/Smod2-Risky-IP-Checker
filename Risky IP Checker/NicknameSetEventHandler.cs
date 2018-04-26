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
			if (plugin.GetConfigBool("kick_risky_ips"))
			{
				string[] userAddress = player.IpAddress.Split(':');
				string endAddress = userAddress[userAddress.Length - 1].Trim();

				foreach (string whitelistIP in plugin.GetConfigList("risky_ip_whitelist"))
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
