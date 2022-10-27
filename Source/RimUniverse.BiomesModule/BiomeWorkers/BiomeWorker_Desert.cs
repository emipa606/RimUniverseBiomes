using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Desert : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < -8f or > 510f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= -8f and <= -7f && tile.rainfall <= 296f ||
            tile.temperature is >= -7f and <= -6f && tile.rainfall <= 152f ||
            tile.temperature is >= -6f and <= -5f && tile.rainfall <= 132f ||
            tile.temperature is >= -5f and <= -4f && tile.rainfall <= 129f ||
            tile.temperature is >= -4f and <= -3f && tile.rainfall <= 130f ||
            tile.temperature is >= -3f and <= -2f && tile.rainfall <= 140f ||
            tile.temperature is >= -2f and <= -1f && tile.rainfall <= 151f ||
            tile.temperature is >= -1f and <= 0f && tile.rainfall <= 162f ||
            tile.temperature is >= 0f and <= 1f && tile.rainfall <= 172f ||
            tile.temperature is >= 1f and <= 2f && tile.rainfall <= 182f ||
            tile.temperature is >= 2f and <= 3f && tile.rainfall <= 192f ||
            tile.temperature is >= 3f and <= 4f && tile.rainfall <= 202f ||
            tile.temperature is >= 4f and <= 5f && tile.rainfall <= 212f ||
            tile.temperature is >= 5f and <= 6f && tile.rainfall <= 220f ||
            tile.temperature is >= 6f and <= 7f && tile.rainfall <= 230f ||
            tile.temperature is >= 7f and <= 8f && tile.rainfall <= 240f ||
            tile.temperature is >= 8f and <= 9f && tile.rainfall <= 250f ||
            tile.temperature is >= 9f and <= 10f && tile.rainfall <= 260f ||
            tile.temperature is >= 10f and <= 11f && tile.rainfall <= 270f ||
            tile.temperature is >= 11f and <= 12f && tile.rainfall <= 280f ||
            tile.temperature is >= 12f and <= 13f && tile.rainfall <= 290f ||
            tile.temperature is >= 13f and <= 14f && tile.rainfall <= 301f ||
            tile.temperature is >= 14f and <= 15f && tile.rainfall <= 313f ||
            tile.temperature is >= 15f and <= 16f && tile.rainfall <= 325f ||
            tile.temperature is >= 16f and <= 17f && tile.rainfall <= 338f ||
            tile.temperature is >= 17f and <= 18f && tile.rainfall <= 351f ||
            tile.temperature is >= 18f and <= 19f && tile.rainfall <= 365f ||
            tile.temperature is >= 19f and <= 20f && tile.rainfall <= 378f ||
            tile.temperature is >= 20f and <= 21f && tile.rainfall <= 392f ||
            tile.temperature is >= 21f and <= 22f && tile.rainfall <= 406f ||
            tile.temperature is >= 22f and <= 23f && tile.rainfall <= 419f ||
            tile.temperature is >= 23f and <= 24f && tile.rainfall <= 432f ||
            tile.temperature is >= 24f and <= 25f && tile.rainfall <= 445f ||
            tile.temperature is >= 25f and <= 26f && tile.rainfall <= 459f ||
            tile.temperature is >= 26f and <= 27f && tile.rainfall <= 472f ||
            tile.temperature is >= 27f and <= 28f && tile.rainfall <= 485f ||
            tile.temperature is >= 28f and <= 29f && tile.rainfall <= 498f ||
            tile.temperature >= 29f && tile.rainfall <= 510f)
        {
            return 10f + tile.temperature - (tile.rainfall / 100) - (tile.elevation / 100);
        }

        return 0f;
    }
}