using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Grassland : BiomeWorker
{
    public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature is < -8f or > 18f || tile.rainfall is < 266f or > 1194f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= -8f and <= -7f && tile.rainfall is >= 296f and <= 451f ||
            tile.temperature is >= -7f and <= -6f && tile.rainfall is >= 278f and <= 412f ||
            tile.temperature is >= -6f and <= -5f && tile.rainfall is >= 270f and <= 400f ||
            tile.temperature is >= -5f and <= -4f && tile.rainfall is >= 266f and <= 382f ||
            tile.temperature is >= -4f and <= -3f && tile.rainfall is >= 271f and <= 389f ||
            tile.temperature is >= -3f and <= -2f && tile.rainfall is >= 282f and <= 402f ||
            tile.temperature is >= -2f and <= -1f && tile.rainfall is >= 301f and <= 427f ||
            tile.temperature is >= -1f and <= 0f && tile.rainfall is >= 323f and <= 460f ||
            tile.temperature is >= 0f and <= 1f && tile.rainfall is >= 346f and <= 505f ||
            tile.temperature is >= 1f and <= 2f && tile.rainfall is >= 369f and <= 566f ||
            tile.temperature is >= 2f and <= 3f && tile.rainfall is >= 392f and <= 643f ||
            tile.temperature is >= 3f and <= 4f && tile.rainfall is >= 416f and <= 710f ||
            tile.temperature is >= 4f and <= 5f && tile.rainfall is >= 440f and <= 770f ||
            tile.temperature is >= 5f and <= 6f && tile.rainfall is >= 465f and <= 822f ||
            tile.temperature is >= 6f and <= 7f && tile.rainfall is >= 491f and <= 870f ||
            tile.temperature is >= 7f and <= 8f && tile.rainfall is >= 518f and <= 912f ||
            tile.temperature is >= 8f and <= 9f && tile.rainfall is >= 543f and <= 951f ||
            tile.temperature is >= 9f and <= 10f && tile.rainfall is >= 568f and <= 990f ||
            tile.temperature is >= 10f and <= 11f && tile.rainfall is >= 592f and <= 1021f ||
            tile.temperature is >= 11f and <= 12f && tile.rainfall is >= 617f and <= 1051f ||
            tile.temperature is >= 12f and <= 13f && tile.rainfall is >= 642f and <= 1080f ||
            tile.temperature is >= 13f and <= 14f && tile.rainfall is >= 667f and <= 1108f ||
            tile.temperature is >= 14f and <= 15f && tile.rainfall is >= 690f and <= 1132f ||
            tile.temperature is >= 15f and <= 16f && tile.rainfall is >= 709f and <= 1155f ||
            tile.temperature is >= 16f and <= 17f && tile.rainfall is >= 727f and <= 1176f ||
            tile.temperature is >= 17f and <= 18f && tile.rainfall is >= 743f and <= 1194f)
        {
            return 5f + tile.temperature + (tile.rainfall / 100);
        }

        return 0f;
    }
}