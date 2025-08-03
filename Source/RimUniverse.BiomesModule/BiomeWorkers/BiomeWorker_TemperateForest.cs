using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_TemperateForest : BiomeWorker
{
    public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < 5f or > 19f || tile.rainfall is < 836f or > 2317f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= 5f and <= 6f && tile.rainfall is >= 836f and <= 1684f ||
            tile.temperature is >= 6f and <= 7f && tile.rainfall is >= 929f and <= 1800f ||
            tile.temperature is >= 7f and <= 8f && tile.rainfall is >= 1001f and <= 1851f ||
            tile.temperature is >= 8f and <= 9f && tile.rainfall is >= 1080f and <= 1902f ||
            tile.temperature is >= 9f and <= 10f && tile.rainfall is >= 1148f and <= 1952f ||
            tile.temperature is >= 10f and <= 11f && tile.rainfall is >= 1209f and <= 1999f ||
            tile.temperature is >= 11f and <= 12f && tile.rainfall is >= 1265f and <= 2044f ||
            tile.temperature is >= 12f and <= 13f && tile.rainfall is >= 1318f and <= 2086f ||
            tile.temperature is >= 13f and <= 14f && tile.rainfall is >= 1365f and <= 2129f ||
            tile.temperature is >= 14f and <= 15f && tile.rainfall is >= 1408f and <= 2170f ||
            tile.temperature is >= 15f and <= 16f && tile.rainfall is >= 1449f and <= 2208f ||
            tile.temperature is >= 16f and <= 17f && tile.rainfall is >= 1486f and <= 2245f ||
            tile.temperature is >= 17f and <= 18f && tile.rainfall is >= 1520f and <= 2281f ||
            tile.temperature is >= 18f and <= 19f && tile.rainfall is >= 1550f and <= 2317f)
        {
            return tile.temperature + (tile.rainfall / 100f) - tile.swampiness;
        }

        return 0f;
    }
}