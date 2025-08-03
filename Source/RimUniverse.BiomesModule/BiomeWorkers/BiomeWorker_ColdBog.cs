using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_ColdBog : BiomeWorker
{
    public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < -8f or > 5f)
        {
            return -100f;
        }

        switch (tile.swampiness)
        {
            case >= 0.90f:
                return 100f;
            // CONDITIONAL PARAMETERS
            case < 0.90f:
                return 5f + (((tile.temperature / 2f) + (tile.rainfall / 100f) - (tile.elevation / 100f)) *
                             tile.swampiness);
            default:
                return 0f;
        }
    }
}