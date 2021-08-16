using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_TropicalRainforest : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 19f || tile.rainfall < 2317f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= 19f and <= 20f && tile.rainfall is >= 2317f and <= 3450f ||
                tile.temperature is >= 20f and <= 21f && tile.rainfall is >= 2351f and <= 3572f ||
                tile.temperature is >= 21f and <= 22f && tile.rainfall is >= 2385f and <= 3705f ||
                tile.temperature is >= 22f and <= 23f && tile.rainfall is >= 2417f and <= 3848f ||
                tile.temperature is >= 23f and <= 24f && tile.rainfall is >= 2448f and <= 4004f ||
                tile.temperature is >= 24f and <= 25f && tile.rainfall is >= 2479f and <= 4215f ||
                tile.temperature is >= 25f and <= 26f && tile.rainfall is >= 2509f and <= 4422f ||
                tile.temperature is >= 26f and <= 27f && tile.rainfall is >= 2536f and <= 4478f ||
                tile.temperature is >= 27f and <= 28f && tile.rainfall is >= 2563f and <= 4404f ||
                tile.temperature is >= 28f and <= 29f && tile.rainfall is >= 2590f and <= 4232f ||
                tile.temperature is >= 29f and <= 30f && tile.rainfall is >= 2615f and <= 3900f ||
                tile.temperature >= 30f && tile.rainfall is >= 2640f and <= 3500f)
            {
                return tile.temperature + (tile.rainfall / 100f) - (tile.elevation / 100f);
            }

            return 0f;
        }
    }
}