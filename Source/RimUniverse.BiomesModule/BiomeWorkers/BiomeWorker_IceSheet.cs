using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_IceSheet : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature > -20f)
        {
            return -100f;
        }

        switch (tile.temperature)
        {
            case < -25f:
                return 100f;
            // CONDITIONAL PARAMETERS
            case >= -25f:
                return 10f + -tile.temperature - (tile.elevation / 100f);
            default:
                return 0f;
        }
    }
}