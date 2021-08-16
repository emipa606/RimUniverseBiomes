using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Savanna : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 18f || tile.rainfall < 759f || tile.rainfall > 1315f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= 18f and <= 19f && tile.rainfall is >= 759f and <= 1212f ||
                tile.temperature is >= 19f and <= 20f && tile.rainfall is >= 774f and <= 1228f ||
                tile.temperature is >= 20f and <= 21f && tile.rainfall is >= 789f and <= 1242f ||
                tile.temperature is >= 21f and <= 22f && tile.rainfall is >= 802f and <= 1256f ||
                tile.temperature is >= 22f and <= 23f && tile.rainfall is >= 815f and <= 1269f ||
                tile.temperature is >= 23f and <= 24f && tile.rainfall is >= 828f and <= 1279f ||
                tile.temperature is >= 24f and <= 25f && tile.rainfall is >= 840f and <= 1288f ||
                tile.temperature is >= 25f and <= 26f && tile.rainfall is >= 850f and <= 1296f ||
                tile.temperature is >= 26f and <= 27f && tile.rainfall is >= 860f and <= 1304f ||
                tile.temperature is >= 27f and <= 28f && tile.rainfall is >= 870f and <= 1309f ||
                tile.temperature is >= 28f and <= 29f && tile.rainfall is >= 878f and <= 1314f ||
                tile.temperature >= 29f && tile.rainfall is >= 885f and <= 1315f)
            {
                return 5f * tile.temperature / ((tile.rainfall / 100) + (tile.elevation / 100));
            }

            return 0f;
        }
    }
}