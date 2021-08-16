using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_BorealForest : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.temperature > 5f || tile.rainfall < 389f ||
                tile.rainfall > 1684f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= -8f and <= -7f && tile.rainfall is >= 451f and <= 451f ||
                tile.temperature is >= -7f and <= -6f && tile.rainfall is >= 412f and <= 750f ||
                tile.temperature is >= -6f and <= -5f && tile.rainfall is >= 400f and <= 890f ||
                tile.temperature is >= -5f and <= -4f && tile.rainfall is >= 382f and <= 1001f ||
                tile.temperature is >= -4f and <= -3f && tile.rainfall is >= 389f and <= 1100f ||
                tile.temperature is >= -3f and <= -2f && tile.rainfall is >= 402f and <= 1190f ||
                tile.temperature is >= -2f and <= -1f && tile.rainfall is >= 427f and <= 1272f ||
                tile.temperature is >= -1f and <= 0f && tile.rainfall is >= 460f and <= 1350f ||
                tile.temperature is >= 0f and <= 1f && tile.rainfall is >= 505f and <= 1422f ||
                tile.temperature is >= 1f and <= 2f && tile.rainfall is >= 566f and <= 1492f ||
                tile.temperature is >= 2f and <= 3f && tile.rainfall is >= 643f and <= 1560f ||
                tile.temperature is >= 3f and <= 4f && tile.rainfall is >= 731f and <= 1623f ||
                tile.temperature is >= 4f and <= 5f && tile.rainfall is >= 836f and <= 1684f)
            {
                return -tile.temperature + (tile.rainfall / 100f * (tile.elevation / 300f));
            }

            return 5f + (tile.rainfall / 100f * (tile.elevation / 500f));
        }
    }
}