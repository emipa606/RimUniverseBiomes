using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Permafrost : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -25f || tile.temperature > -15f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= -25f and <= -20f)
            {
                return -tile.temperature + (tile.elevation / 100f) - (tile.rainfall / 100f);
            }

            if (tile.temperature > -20f)
            {
                return -tile.temperature + (tile.elevation / 75f) - (tile.rainfall / 75f);
            }

            return 0f;
        }
    }
}