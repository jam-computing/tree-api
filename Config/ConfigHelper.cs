using TreeAPI.Types;

namespace TreeAPI.Config;

public static class ConfigHelper
{
    public static IpAddr GetIp(this string path) =>
        ConfigManager.GetIpAddr(path);

}