using HarmonyLib;
using RimWorld;
using Verse;

namespace RimUniverse.BiomesModule;

[HarmonyPatch(typeof(GenStep_RockChunks), nameof(GenStep_RockChunks.Generate))]
public static class GenStep_RockChunks_Generate
{
    public static bool Prefix(Map map)
    {
        return map.Biome != BiomeDefOf.IceSheet;
    }
}