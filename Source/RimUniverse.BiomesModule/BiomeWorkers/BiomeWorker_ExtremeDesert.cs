using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_ExtremeDesert : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }

            if (tile.rainfall >= 500f)
            {
                return 0f;
            }

            if (tile.temperature is > -2f and <= -1f && tile.rainfall < 50f ||
                tile.temperature is > -1f and <= 0f && tile.rainfall < 55f ||
                tile.temperature is > 0f and <= 1f && tile.rainfall < 60f ||
                tile.temperature is > 1f and <= 2f && tile.rainfall < 65f ||
                tile.temperature is > 2f and <= 3f && tile.rainfall < 70f ||
                tile.temperature is > 3f and <= 4f && tile.rainfall < 75f ||
                tile.temperature is > 4f and <= 5f && tile.rainfall < 80f ||
                tile.temperature is > 5f and <= 6f && tile.rainfall < 85f ||
                tile.temperature is > 6f and <= 7f && tile.rainfall < 90f ||
                tile.temperature is > 7f and <= 8f && tile.rainfall < 95f ||
                tile.temperature is > 8f and <= 9f && tile.rainfall < 100f ||
                tile.temperature is > 9f and <= 10f && tile.rainfall < 110f ||
                tile.temperature is > 10f and <= 11f && tile.rainfall < 120f ||
                tile.temperature is > 11f and <= 12f && tile.rainfall < 130f ||
                tile.temperature is > 12f and <= 13f && tile.rainfall < 140f ||
                tile.temperature is > 13f and <= 14f && tile.rainfall < 150f ||
                tile.temperature is > 14f and <= 15f && tile.rainfall < 160f ||
                tile.temperature is > 15f and <= 16f && tile.rainfall < 170f ||
                tile.temperature is > 16f and <= 17f && tile.rainfall < 180f ||
                tile.temperature is > 17f and <= 18f && tile.rainfall < 190f ||
                tile.temperature is > 18f and <= 19f && tile.rainfall < 200f ||
                tile.temperature is > 19f and <= 20f && tile.rainfall < 220f ||
                tile.temperature is > 20f and <= 21f && tile.rainfall < 240f ||
                tile.temperature is > 21f and <= 22f && tile.rainfall < 260f ||
                tile.temperature is > 22f and <= 23f && tile.rainfall < 280f ||
                tile.temperature is > 23f and <= 24f && tile.rainfall < 300f ||
                tile.temperature is > 24f and <= 25f && tile.rainfall < 320f ||
                tile.temperature is > 25f and <= 26f && tile.rainfall < 340f ||
                tile.temperature is > 26f and <= 27f && tile.rainfall < 360f ||
                tile.temperature is > 27f and <= 28f && tile.rainfall < 380f ||
                tile.temperature is > 28f and <= 29f && tile.rainfall < 400f ||
                tile.temperature is > 29f and <= 30f && tile.rainfall < 425f ||
                tile.temperature is > 30f and <= 31f && tile.rainfall < 460f ||
                tile.temperature > 31f && tile.rainfall < 520f)
            {
                return (tile.temperature * 1.5f) - (tile.rainfall / 100f);
            }

            return 0f;
        }
    }
}