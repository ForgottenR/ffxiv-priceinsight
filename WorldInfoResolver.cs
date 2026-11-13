using System.Collections.Generic;

namespace PriceInsight;

internal static class WorldInfoResolver
{
    public static (string Name, string DcName, string Region) GetOrUnknown(
        IReadOnlyDictionary<uint, (string Name, string DcName, string Region)> worldLookup,
        uint? worldId)
    {
        if (worldId.HasValue && worldLookup.TryGetValue(worldId.Value, out var worldInfo))
            return worldInfo;

        return ("Unknown", "Unknown", "unknown");
    }
}
