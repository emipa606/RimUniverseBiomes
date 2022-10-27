using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Debug : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered)
        {
            return -100f;
        }

        return -20f;
    }
}