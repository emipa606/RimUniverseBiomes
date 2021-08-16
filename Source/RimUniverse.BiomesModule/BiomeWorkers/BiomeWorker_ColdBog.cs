using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_ColdBog : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.temperature > 5f)
            {
                return -100f;
            }

            if (tile.swampiness >= 0.90f)
            {
                return 100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.swampiness < 0.90f)
            {
                return 5f + (((tile.temperature / 2f) + (tile.rainfall / 100f) - (tile.elevation / 100f)) *
                             tile.swampiness);
            }

            return 0f;
        }
    }
}