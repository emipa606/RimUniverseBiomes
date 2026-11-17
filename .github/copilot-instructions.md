# GitHub Copilot Instructions for RimUniverse - Biomes (Continued)

## Overview

RimUniverse - Biomes (Continued) is a RimWorld mod that reworks the game's biomes to better simulate real-life biome distribution based on Whittaker's biome diagram. It adds new biomes such as Permafrost, Grassland, Savanna, Woodland, and Moist Deciduous Forest, and makes water bodies such as rivers, lakes, marshes, and coastal waters respond to extreme low temperatures by freezing the water. This mod is compatible with other RimWorld mods and can be used alongside them without issues.

## Key Features and Systems

- **Biomes Reworked**: The mod reworks the game's biomes to better simulate real-life biome distribution based on Whittaker's biome diagram.
- **New Biomes**: The mod adds new biomes such as Permafrost, Grassland, Savanna, Woodland, and Moist Deciduous Forest.
- **Water Responsive**: Rivers, lakes, marshes, and coastal waters respond to extreme low temperatures by freezing the water.

## Coding Patterns and Conventions

The mod follows the following coding patterns and conventions:

- **Mod Structure**: The mod is organized into submods, each of which handles a specific feature of the mod.
- **C# Code**: The mod uses C# code to implement the various features of the mod, including biome rework and water responsiveness.
- **XML Integration**: The mod uses XML files to define the biomes and other game objects.

## XML Integration

The mod uses XML files to define the biomes and other game objects. The XML files are located in the `Defs` folder of the mod and are structured as follows:

xml
<Defs>
    <BiomeDef>
        <defName>Cold</defName>
        <label>Cold</label>
        <description>A cold biome.</description>
        <temperatureRange>
            <min>-10</min>
            <max>5</max>
        </temperatureRange>
    </BiomeDef>
</Defs>


## Harmony Patching

The mod uses Harmony patching to modify the behavior of the game. Harmony patching allows the mod to modify the code of the game without having to modify the game's source code. The mod uses Harmony patching to modify the behavior of the game's biome generation system and water system.

## Suggestions for Copilot

Here are some suggestions for Copilot:

- Use Copilot to generate C# code for new features or bug fixes.
- Use Copilot to generate XML files for new biomes or other game objects.
- Use Copilot to generate Harmony patches for modifying the game's behavior.
- Use Copilot to generate test cases for new features or bug fixes.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

