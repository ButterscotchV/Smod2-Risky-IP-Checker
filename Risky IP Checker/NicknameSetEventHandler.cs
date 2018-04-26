using RiskyIPCheckerPlugin;
using Smod2.API;
using Smod2.Events;

namespace Smod.Events
{
	class NicknameSetHandler : IEventNicknameSet
	{
		private RiskyIPChecker plugin;

		public NicknameSetHandler(RiskyIPChecker plugin)
		{
			this.plugin = plugin;
		}

		public void OnNicknameSet(Player player, string nickname, out string nicknameOutput)
		{
			nicknameOutput = nickname;

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
