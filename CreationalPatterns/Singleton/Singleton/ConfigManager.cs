namespace Singleton
{
    public sealed class ConfigManager : IConfigManager
    {
        private static readonly Lazy<ConfigManager> _instance = new(() => new ConfigManager());

        public static ConfigManager Instance => _instance.Value;

        public Dictionary<string, string> Settings { get; } = [];

        private ConfigManager()
        {
            Settings["PaymentGateway"] = "Stripe";
            Settings["MaxRetries"] = "3";
        }
    }
}
