using Multiplayer.API;
using RimUniverse.CoreModule;
using RimWorld;
using UnityEngine;
using Verse;

namespace RimUniverse.BiomesModule.Submods.WaterFreezes;

public class WaterFreezes : MapComponent
{
    public int loopCycle;

    public WaterFreezes(Map map) : base(map)
    {
    }

    public override void MapComponentTick()
    {
        if (Controller.Settings.waterResponsive.Equals(false) || map.Biome == BiomeDefOf.SeaIce)
        {
            return;
        }

        base.MapComponentTick();
        var mapArea = MP.enabled
            ? Mathf.RoundToInt(map.Area * 0.000175f)
            : Mathf.RoundToInt(map.Area * Rand.Range(0.000065f, 0.000320f));

        for (var i = 0; i < mapArea; i++)
        {
            loopCycle++;
            if (loopCycle >= map.Area)
            {
                loopCycle = 0;
            }

            var terrainCell = map.cellsInRandomOrder.Get(loopCycle);
            GenTemperature.TryGetTemperatureForCell(terrainCell, map, out var terrainTemp);
            var shallowSpeed = terrainTemp is < 0f and > -20f ? -terrainTemp * 7f : -terrainTemp * 18f;
            var deepSpeed = terrainTemp is < 0f and > -20f ? -terrainTemp / 10f : -terrainTemp / 3f;
            var thawSpeed = terrainTemp < 0f ? -terrainTemp * 10f : terrainTemp * 21f;
            var terrainDef = map.terrainGrid.TerrainAt(terrainCell);

            // freeze process
            if (terrainTemp < -35f)
            {
                if (terrainDef.defName == "WaterOceanShallow")
                {
                    var toFreeze = 0;
                    var tempConstant = 0f;
                    var tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                    tileList.Add(terrainCell);
                    var newTile = tileList.RandomElement();
                    if (newTile.InBounds(map))
                    {
                        if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                        {
                            toFreeze++;
                            tempConstant++;
                        }

                        if (terrainDef.defName == "WaterOceanShallow")
                        {
                            if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 30f))
                            {
                                string iceName;
                                if (terrainDef.defName == "WaterOceanShallow")
                                {
                                    iceName = "IceOceanShallow";
                                }
                                else
                                {
                                    continue;
                                }

                                map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                            }
                        }
                    }
                }
            }

            if (terrainTemp < -20f)
            {
                if (terrainDef.defName is "WaterMovingShallow" or "WaterMovingChestDeep")
                {
                    var toFreeze = 0;
                    var tempConstant = 0f;
                    var tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                    tileList.Add(terrainCell);
                    var newTile = tileList.RandomElement();
                    if (newTile.InBounds(map))
                    {
                        if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                        {
                            toFreeze++;
                            tempConstant++;
                        }

                        switch (terrainDef.defName)
                        {
                            case "WaterMovingShallow":
                            {
                                if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 30f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterMovingShallow")
                                    {
                                        iceName = "IceMovingShallow";
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }

                                break;
                            }
                            case "WaterMovingChestDeep":
                            {
                                if (Rand.Value < deepSpeed * toFreeze * (tempConstant * 3f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterMovingChestDeep")
                                    {
                                        iceName = "IceMovingChestDeep";
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }

                                break;
                            }
                        }
                    }
                }
            }

            if (terrainTemp < 0f)
            {
                if (terrainDef.defName is "WaterShallow" or "Marsh" or "WaterDeep" or "WaterOceanShallow")
                {
                    var toFreeze = 0;
                    var tempConstant = 0f;
                    var tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                    tileList.Add(terrainCell);
                    var newTile = tileList.RandomElement();
                    if (newTile.InBounds(map))
                    {
                        if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                        {
                            toFreeze++;
                            tempConstant++;
                        }

                        switch (terrainDef.defName)
                        {
                            case "WaterShallow":
                            case "Marsh":
                            {
                                if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 10f))
                                {
                                    var iceName = terrainDef.defName == "WaterShallow" ? "IceShallow" : "IceMarsh";

                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }

                                break;
                            }
                            case "WaterDeep":
                            {
                                if (Rand.Value < deepSpeed * toFreeze * (tempConstant * 10f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterDeep")
                                    {
                                        iceName = "IceDeep";
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }

                                break;
                            }
                        }
                    }
                }
            }

            // Thaw process
            string waterName;
            if (terrainTemp > -19f)
            {
                if (terrainDef.defName == "IceOceanShallow")
                {
                    var toThaw = 0;
                    var tempConstant = 0f;
                    var tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                    tileList.Add(terrainCell);
                    var newTile = tileList.RandomElement();
                    if (newTile.InBounds(map))
                    {
                        if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Ice") &&
                            map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                        {
                            toThaw++;
                            tempConstant++;
                        }

                        if (Rand.Value < thawSpeed * toThaw * (tempConstant * 5f))
                        {
                            if (terrainDef.defName == "IceOceanShallow")
                            {
                                waterName = "WaterOceanShallow";
                            }
                            else
                            {
                                continue;
                            }

                            if (waterName.Contains("Water"))
                            {
                                map.snowGrid.SetDepth(terrainCell, 0f);
                            }

                            map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
                        }
                    }
                }
            }

            if (terrainTemp > -13f)
            {
                if (terrainDef.defName is "IceMovingShallow" or "IceMovingChestDeep")
                {
                    var toThaw = 0;
                    var tempConstant = 0f;
                    var tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                    tileList.Add(terrainCell);
                    var newTile = tileList.RandomElement();
                    if (newTile.InBounds(map))
                    {
                        if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Ice") &&
                            map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                            map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                        {
                            toThaw++;
                            tempConstant++;
                        }

                        if (Rand.Value < thawSpeed * toThaw * (tempConstant * 5f))
                        {
                            waterName = terrainDef.defName == "IceMovingShallow"
                                ? "WaterMovingShallow"
                                : "WaterMovingChestDeep";

                            if (waterName.Contains("Water"))
                            {
                                map.snowGrid.SetDepth(terrainCell, 0f);
                            }

                            map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
                        }
                    }
                }
            }

            if (!(terrainTemp > 0f))
            {
                continue;
            }

            if (terrainDef.defName != "IceShallow" && terrainDef.defName != "IceDeep" &&
                terrainDef.defName != "IceMarsh")
            {
                continue;
            }

            var thaw = 0;
            var cellsCardinal = GenAdjFast.AdjacentCellsCardinal(terrainCell);
            cellsCardinal.Add(terrainCell);
            var element = cellsCardinal.RandomElement();
            if (!element.InBounds(map))
            {
                continue;
            }

            if (!map.terrainGrid.TerrainAt(element).defName.Contains("Ice") &&
                map.terrainGrid.TerrainAt(element).defName != "BridgeMarsh" &&
                map.terrainGrid.TerrainAt(element).defName != "Bridge")
            {
                thaw++;
            }

            if (!(Rand.Value < thawSpeed * thaw))
            {
                continue;
            }

            switch (terrainDef.defName)
            {
                case "IceShallow":
                    waterName = "WaterShallow";
                    break;
                case "IceDeep":
                    waterName = "WaterDeep";
                    break;
                default:
                    waterName = "Marsh";
                    break;
            }

            if (waterName.Contains("Water") || waterName == "Marsh")
            {
                map.snowGrid.SetDepth(terrainCell, 0f);
            }

            map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
        }
    }
}