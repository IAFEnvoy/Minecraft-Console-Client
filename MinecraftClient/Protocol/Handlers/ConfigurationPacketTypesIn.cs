namespace MinecraftClient.Protocol.Handlers;

public enum ConfigurationPacketTypesIn
{
    PluginMessage,
    Disconnect,
    FinishConfiguration,
    KeepAlive,
    Ping,
    RegistryData,
    ResourcePack,
    FeatureFlags,
    UpdateTags,
    
    Unknown
}