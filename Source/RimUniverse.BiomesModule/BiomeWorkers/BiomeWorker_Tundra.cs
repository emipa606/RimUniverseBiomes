using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Tundra : BiomeWorker
{
    public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < -15f or > -8f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature >= -15f)
        {
            return 10f + -tile.temperature + (tile.elevation / 100f) - (tile.rainfall / 100f);
        }

        return 0f;
    }
}