# Smod2-Risky-IP-Checker
The Risky IP Checker plugin for Smod2

## Config Additions
### Risky IP Checker
#### Before using this, make sure you check out the API that's used, https://getipintel.net/
Config Option | Value Type | Default Value | Description
--- | :---: | :---: | ---
risky_ip_checker | Boolean | False | Enables/Disables Risky IP Checker (Uses https://getipintel.net/)
clear_ip_cache_after | Integer | 50 | The number of rounds until the cached IPs are cleared
risky_ips_ratelimit | Seconds | 30 | The seconds between requests (CHECK https://getipintel.net/#API)
risky_ips_email | String | **Empty** | Your email, this is used in requests
risky_ips_subdomain | String | check | If you get a custom subdomain for https://getipintel.net/, use it here
kick_risky_ips_at_percent | Float | 95.0 | The percentage of suspicion to kick a player
ban_risky_ips_at_percent | Float | 100.0 | The percentage of suspicion to ban a player
no_check_ip_whitelist | List | **Empty** | A list of IPs to not check (Prevent them from being kicked / banned)
use_country_restrictions | Boolean | False | Enables/Disables Country Restrictions (Uses https://getipintel.net/)
country_whitelist| List | **Empty** | A list of countries to whitelist, uses Country Code ISO 3166-1 alpha-2 (If this is set, only these countries can connect)
country_blacklist | List | **Empty** | A list of countries to blacklist, uses Country Code ISO 3166-1 alpha-2