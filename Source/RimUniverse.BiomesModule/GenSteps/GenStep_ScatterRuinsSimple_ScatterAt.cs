using HarmonyLib;
using RimWorld;
using Verse;

namespace RimUniverse.BiomesModule
{
    [HarmonyPatch(typeof(GenStep_ScatterRuinsSimple), "ScatterAt")]
    public class GenStep_ScatterRuinsSimple_ScatterAt
    {
        [HarmonyPrefix]
        public static bool Prefix(Map map)
        {
            return map.Biome != BiomeDefOf.IceSheet;
        }
    }
}