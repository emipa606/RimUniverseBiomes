using HarmonyLib;
using RimWorld;
using Verse;

namespace RimUniverse.BiomesModule;

[HarmonyPatch(typeof(GenStep_ScatterShrines), "ScatterAt")]
public class GenStep_ScatterShrines_ScatterAt
{
    [HarmonyPrefix]
    public static bool Prefix(Map map)
    {
        return map.Biome != BiomeDefOf.IceSheet;
    }
}