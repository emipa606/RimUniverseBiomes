using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_AridShrubland : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.rainfall < 129f || tile.rainfall > 885f)
            {
                return -100f;
            }

            // CONDITIONAL PARAMETERS
            if (tile.temperature is >= -8f and <= -7f && tile.rainfall is >= 296f and < 297f ||
                tile.temperature is >= -7f and <= -6f && tile.rainfall is >= 152f and < 278f ||
                tile.temperature is >= -6f and <= -5f && tile.rainfall is >= 132f and < 270f ||
                tile.temperature is >= -5f and <= -4f && tile.rainfall is >= 129f and < 266f ||
                tile.temperature is >= -4f and <= -3f && tile.rainfall is >= 130f and < 271f ||
                tile.temperature is >= -3f and <= -2f && tile.rainfall is >= 140f and < 282f ||
                tile.temperature is >= -2f and <= -1f && tile.rainfall is >= 151f and < 301f ||
                tile.temperature is >= -1f and <= 0f && tile.rainfall is >= 162f and < 323f ||
                tile.temperature is >= 0f and <= 1f && tile.rainfall is >= 172f and < 346f ||
                tile.temperature is >= 1f and <= 2f && tile.rainfall is >= 182f and < 369f ||
                tile.temperature is >= 2f and <= 3f && tile.rainfall is >= 192f and < 392f ||
                tile.temperature is >= 3f and <= 4f && tile.rainfall is >= 202f and < 416f ||
                tile.temperature is >= 4f and <= 5f && tile.rainfall is >= 212f and < 440f ||
                tile.temperature is >= 5f and <= 6f && tile.rainfall is >= 220f and < 465f ||
                tile.temperature is >= 6f and <= 7f && tile.rainfall is >= 230f and < 491f ||
                tile.temperature is >= 7f and <= 8f && tile.rainfall is >= 240f and < 518f ||
                tile.temperature is >= 8f and <= 9f && tile.rainfall is >= 250f and < 543f ||
                tile.temperature is >= 9f and <= 10f && tile.rainfall is >= 260f and < 568f ||
                tile.temperature is >= 10f and <= 11f && tile.rainfall is >= 270f and < 592f ||
                tile.temperature is >= 11f and <= 12f && tile.rainfall is >= 280f and < 617f ||
                tile.temperature is >= 12f and <= 13f && tile.rainfall is >= 290f and < 642f ||
                tile.temperature is >= 13f and <= 14f && tile.rainfall is >= 301f and < 667f ||
                tile.temperature is >= 14f and <= 15f && tile.rainfall is >= 313f and < 690f ||
                tile.temperature is >= 15f and <= 16f && tile.rainfall is >= 325f and < 709f ||
                tile.temperature is >= 16f and <= 17f && tile.rainfall is >= 338f and < 727f ||
                tile.temperature is >= 17f and <= 18f && tile.rainfall is >= 351f and < 743f ||
                tile.temperature is >= 18f and <= 19f && tile.rainfall is >= 365f and < 759f ||
                tile.temperature is >= 19f and <= 20f && tile.rainfall is >= 378f and < 774f ||
                tile.temperature is >= 20f and <= 21f && tile.rainfall is >= 392f and < 789f ||
                tile.temperature is >= 21f and <= 22f && tile.rainfall is >= 406f and < 802f ||
                tile.temperature is >= 22f and <= 23f && tile.rainfall is >= 419f and < 815f ||
                tile.temperature is >= 23f and <= 24f && tile.rainfall is >= 432f and < 828f ||
                tile.temperature is >= 24f and <= 25f && tile.rainfall is >= 445f and < 840f ||
                tile.temperature is >= 25f and <= 26f && tile.rainfall is >= 459f and < 850f ||
                tile.temperature is >= 26f and <= 27f && tile.rainfall is >= 472f and < 860f ||
                tile.temperature is >= 27f and <= 28f && tile.rainfall is >= 485f and < 870f ||
                tile.temperature is >= 28f and <= 29f && tile.rainfall is >= 498f and < 878f ||
                tile.temperature >= 29f && tile.rainfall is >= 510f and < 885f)
            {
                return (-tile.temperature * -tile.temperature / 2f) - (tile.rainfall / 100f) + (tile.elevation / 100f);
            }

            return 1f;
        }
    }
}