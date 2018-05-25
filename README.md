# Smod2-Risky-IP-Checker
The Risky IP Checker plugin for Smod2

## Config Additions
### Risky IP Checker
#### Before using this, make sure you check out the API that's used, https://getipintel.net/
Config Option | Value Type | Default Value | Description
--- | :---: | :---: | ---
kick_risky_ips | Boolean | False | Enables/Disables Risky IP Checker (Uses https://getipintel.net/)
trusted_ips_reset_every | Integer | 10 | The number of rounds until the cached IPs are cleared
kick_risky_ips_ratelimit | Seconds | 30 | The seconds between requests (CHECK https://getipintel.net/#API)
kick_risky_ips_email | String | **Empty** | Your email, this is used in requests
kick_risky_ips_subdomain | String | check | If you get a custom subdomain for https://getipintel.net/, use it here
kick_risky_ips_at_percent | Integer | 95 | The percentage of suspicion to kick a player
ban_risky_ips_at_percent | Integer | 100 | The percentage of suspicion to ban a player
risky_ip_whitelist | List | **Empty** | A list of IPs to not check (Prevent them from being kicked / banned)
use_risky_country | Boolean | false | Enables/Disables Risky Country Checker
only_use_risky_country | Boolean | false | When set to True, risky ip check is disabled and only risky Country Check is enabled
use_white_list_contry | Boolean | false | True use WhiteList/ False use BlackList
risky_country_whitelist | List | **Empty** | A list of Country to whitelist, Use Country Code ISO 3166-1 alpha-2, Warning!  If you do not enter anything, no one can come in."
risky_country_blacklist | List | **Empty** | A list of Country to blacklist, Use Country Code ISO 3166-1 alpha-2