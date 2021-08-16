using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_IceSheet : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature > -20f)
            {
                return -100f;
            }

            if (tile.temperature < -25f)
            {
                return 100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= -25f)
            {
                return 10f + -tile.temperature - (tile.elevation / 100f);
            }

            return 0f;
        }
    }
}