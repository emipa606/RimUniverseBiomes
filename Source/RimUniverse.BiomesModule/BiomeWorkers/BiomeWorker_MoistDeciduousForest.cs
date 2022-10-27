using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_MoistDeciduousForest : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature < 19f || tile.rainfall is < 1579f or > 2640f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= 19f and <= 20f && tile.rainfall is >= 1579f and <= 2317f ||
            tile.temperature is >= 20f and <= 21f && tile.rainfall is >= 1605f and <= 2351f ||
            tile.temperature is >= 21f and <= 22f && tile.rainfall is >= 1628f and <= 2385f ||
            tile.temperature is >= 22f and <= 23f && tile.rainfall is >= 1650f and <= 2417f ||
            tile.temperature is >= 23f and <= 24f && tile.rainfall is >= 1668f and <= 2448f ||
            tile.temperature is >= 24f and <= 25f && tile.rainfall is >= 1685f and <= 2479f ||
            tile.temperature is >= 25f and <= 26f && tile.rainfall is >= 1700f and <= 2509f ||
            tile.temperature is >= 26f and <= 27f && tile.rainfall is >= 1714f and <= 2536f ||
            tile.temperature is >= 27f and <= 28f && tile.rainfall is >= 1726f and <= 2563f ||
            tile.temperature is >= 28f and <= 29f && tile.rainfall is >= 1736f and <= 2590f ||
            tile.temperature is >= 29f and <= 30f && tile.rainfall is >= 1745f and <= 2615f ||
            tile.temperature >= 30f && tile.rainfall is >= 1750f and <= 2640f)
        {
            return (tile.temperature * (tile.elevation / 500f)) + (tile.rainfall / 100f) - tile.swampiness;
        }

        return 0f;
    }
}