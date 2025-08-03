using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Permafrost : BiomeWorker
{
    public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < -25f or > -15f)
        {
            return -100f;
        }

        switch (tile.temperature)
        {
            // CONDITIONAL PARAMETERS
            case >= -25f and <= -20f:
                return -tile.temperature + (tile.elevation / 100f) - (tile.rainfall / 100f);
            case > -20f:
                return -tile.temperature + (tile.elevation / 75f) - (tile.rainfall / 75f);
            default:
                return 0f;
        }
    }
}