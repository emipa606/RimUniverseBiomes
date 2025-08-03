# GitHub Copilot Instructions for RimUniverse - Biomes (Continued)

## Mod Overview and Purpose

"RimUniverse - Biomes (Continued)" is an updated continuation of Balthorazs' original mod, aimed at enhancing the RimWorld experience by reworking and expanding biome types. The mod provides a realistic simulation of biome distribution inspired by Whittaker's biome diagram, as well as features that allow bodies of water to freeze under extreme low temperatures. This mod is part of the RimUniverse series, although it is currently not actively maintained as the developer focuses on other projects.

## Key Features and Systems

- **Biome Rework**: The mod overhauls the biome selection process to mimic real-life ecological zones, leading to more diverse and immersive gameplay environments.
- **New Biomes Added**: Introduces five new biomes: Permafrost, Grassland, Savanna, Woodland, and Moist Deciduous Forest.
- **WaterResponsive System**: A submod feature where rivers, lakes, marsh water, and coastal water freeze under extremely low temperatures, affecting gameplay and strategy.

## Coding Patterns and Conventions

- **Naming Conventions**: Classes related to biomes follow a consistent naming pattern, `BiomeWorker_{BiomeName}`, inheriting from the `BiomeWorker` base class for uniform handling.
- **Structure and Organization**: The source files are organized based on functionality, with each biome getting its own dedicated file and class for clarity and ease of maintenance.

## XML Integration

- XML files are crucial for defining biome properties and integrating them into the game. Ensure XML files are correctly structured to match RimWorld's requirements, typically defining biome parameters like temperature ranges, precipitation, and common vegetation or creatures.

## Harmony Patching

- **Harmony Library**: Utilize the Harmony library to patch RimWorld methods where necessary. This is useful for altering base game logic without directly modifying the original code, ensuring compatibility and ease of updates.
- Create postfix or prefix methods to modify the behavior of biome generation or water response mechanics.
  
## Suggestions for Copilot

- **Autocomplete for Biome Workers**: Utilize GitHub Copilot to assist in generating new `BiomeWorker` classes. Copilot can help reduce repetitive coding through suggestion patterns based on existing code structure.
  
- **Method Suggestions**: Use Copilot to suggest methods for specific tasks such as generating biome features or handling water freezing logic. Explicit and consistent method naming will help Copilot recognize patterns.

- **XML and Harmony**: Copilot can assist with writing XML configurations or Harmony patches by predicting typical tag structures or method alteration patterns based on context within the project.

- **Comments and Documentation**: Encourage Copilot to generate inline comments and documentation to ensure code maintainability and readability for future developers.

- **Error Handling and Optimization**: Prompt Copilot to suggest error handling routines or potential optimizations, especially in complex biome generation algorithms or resource-intensive simulation routines.

By following these guidelines, developers can efficiently extend and maintain the RimUniverse - Biomes mod with the assistance of GitHub Copilot while adhering to consistent coding standards.
