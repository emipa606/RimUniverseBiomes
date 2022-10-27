using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_TemperateSwamp : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < 5f or > 19f || tile.rainfall < 1684)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= 5f and <= 6f && tile.rainfall >= 1684f ||
            tile.temperature is >= 6f and <= 7f && tile.rainfall >= 1800f ||
            tile.temperature is >= 7f and <= 8f && tile.rainfall >= 1851f ||
            tile.temperature is >= 8f and <= 9f && tile.rainfall >= 1902f ||
            tile.temperature is >= 9f and <= 10f && tile.rainfall >= 1952f ||
            tile.temperature is >= 10f and <= 11f && tile.rainfall >= 1999f ||
            tile.temperature is >= 11f and <= 12f && tile.rainfall >= 2044f ||
            tile.temperature is >= 12f and <= 13f && tile.rainfall >= 2086f ||
            tile.temperature is >= 13f and <= 14f && tile.rainfall >= 2129f ||
            tile.temperature is >= 14f and <= 15f && tile.rainfall >= 2170f ||
            tile.temperature is >= 15f and <= 16f && tile.rainfall >= 2208f ||
            tile.temperature is >= 16f and <= 17f && tile.rainfall >= 2245f ||
            tile.temperature is >= 17f and <= 18f && tile.rainfall >= 2281f ||
            tile.temperature is >= 18f and <= 19f && tile.rainfall >= 2317f)
        {
            return tile.temperature + (tile.rainfall / 75f / (tile.elevation / 100f)) + (tile.swampiness * 5);
        }

        return 0f;
    }
}