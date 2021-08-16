using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Tundra : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -15f || tile.temperature > -8f)
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
}