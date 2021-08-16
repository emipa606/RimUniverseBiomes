using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_TropicalSwamp : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 19f || tile.rainfall < 3450f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= 19f and <= 20f && tile.rainfall >= 3450f ||
                tile.temperature is >= 20f and <= 21f && tile.rainfall >= 3572f ||
                tile.temperature is >= 21f and <= 22f && tile.rainfall >= 3705f ||
                tile.temperature is >= 22f and <= 23f && tile.rainfall >= 3848f ||
                tile.temperature is >= 23f and <= 24f && tile.rainfall >= 4004f ||
                tile.temperature is >= 24f and <= 25f && tile.rainfall >= 4215f ||
                tile.temperature is >= 25f and <= 26f && tile.rainfall >= 4422f ||
                tile.temperature is >= 26f and <= 27f && tile.rainfall >= 4478f ||
                tile.temperature is >= 27f and <= 28f && tile.rainfall >= 4404f ||
                tile.temperature is >= 28f and <= 29f && tile.rainfall >= 4232f ||
                tile.temperature is >= 29f and <= 30f && tile.rainfall >= 3900f ||
                tile.temperature >= 30f && tile.rainfall >= 3500f)
            {
                return tile.temperature + (tile.rainfall / 100f * (tile.swampiness * 5f));
            }

            return 0f;
        }
    }
}