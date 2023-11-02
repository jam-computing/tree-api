using TreeAPI.Types;

namespace TreeAPI.Config;

public static class ConfigManager
{
    public static string? IP { get; set; } = "127.0.0.1";
    public static string Path { get; set; } = "Text";
    public static int Port { get; set; } = 1234;
    public static bool Testing { get; set; } = false;
    public static int LedCount { get; set; } = 500;
    public static int DefaultInterval { get; set; } = 20;

    public static IpAddr GetIpAddr(string path) => new()
    {
        Address = IP!,
        Port = Port,
        Path = path
    };

    public static IpAddr GetIpAddr() => new()
    {
        Address = IP!,
        Port = Port,
        Path = Path
    };

}
