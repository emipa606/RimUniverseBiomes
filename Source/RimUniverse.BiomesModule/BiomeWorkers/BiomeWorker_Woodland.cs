using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule;

public class BiomeWorker_Woodland : BiomeWorker
{
    public override float GetScore(Tile tile, int tileID)
    {
        // ABSOLUTE PARAMETERS
        if (tile.WaterCovered || tile.temperature < 4f || tile.rainfall is < 710f or > 1750f)
        {
            return -100f;
        }

        // CONDITIONAL PARAMETERS
        if (tile.temperature is >= 4f and <= 5f && tile.rainfall is >= 710f and < 731f ||
            tile.temperature is >= 5f and <= 6f && tile.rainfall is >= 770f and < 836f ||
            tile.temperature is >= 6f and <= 7f && tile.rainfall is >= 822f and < 929f ||
            tile.temperature is >= 7f and <= 8f && tile.rainfall is >= 870f and < 1001f ||
            tile.temperature is >= 8f and <= 9f && tile.rainfall is >= 912f and < 1080f ||
            tile.temperature is >= 9f and <= 10f && tile.rainfall is >= 951f and < 1148f ||
            tile.temperature is >= 10f and <= 11f && tile.rainfall is >= 990f and < 1209f ||
            tile.temperature is >= 11f and <= 12f && tile.rainfall is >= 1021f and < 1265f ||
            tile.temperature is >= 12f and <= 13f && tile.rainfall is >= 1051f and < 1318f ||
            tile.temperature is >= 13f and <= 14f && tile.rainfall is >= 1080f and < 1365f ||
            tile.temperature is >= 14f and <= 15f && tile.rainfall is >= 1108f and < 1408f ||
            tile.temperature is >= 15f and <= 16f && tile.rainfall is >= 1132f and < 1449f ||
            tile.temperature is >= 16f and <= 17f && tile.rainfall is >= 1155f and < 1486f ||
            tile.temperature is >= 17f and <= 18f && tile.rainfall is >= 1176f and < 1520f ||
            tile.temperature is >= 18f and <= 19f && tile.rainfall is >= 1194f and < 1550f ||
            tile.temperature is >= 19f and <= 20f && tile.rainfall is >= 1212f and < 1579f ||
            tile.temperature is >= 20f and <= 21f && tile.rainfall is >= 1228f and < 1605f ||
            tile.temperature is >= 21f and <= 22f && tile.rainfall is >= 1242f and < 1628f ||
            tile.temperature is >= 22f and <= 23f && tile.rainfall is >= 1256f and < 1650f ||
            tile.temperature is >= 23f and <= 24f && tile.rainfall is >= 1269f and < 1668f ||
            tile.temperature is >= 24f and <= 25f && tile.rainfall is >= 1279f and < 1685f ||
            tile.temperature is >= 25f and <= 26f && tile.rainfall is >= 1288f and < 1700f ||
            tile.temperature is >= 26f and <= 27f && tile.rainfall is >= 1296f and < 1714f ||
            tile.temperature is >= 27f and <= 28f && tile.rainfall is >= 1304f and < 1726f ||
            tile.temperature is >= 28f and <= 29f && tile.rainfall is >= 1309f and < 1736f ||
            tile.temperature is >= 29f and <= 30f && tile.rainfall is >= 1314f and < 1745f ||
            tile.temperature >= 30f && tile.rainfall is >= 1315f and < 1750f)
        {
            return tile.temperature + (tile.rainfall / 100f) - tile.swampiness;
        }

        return 0f;
    }
}