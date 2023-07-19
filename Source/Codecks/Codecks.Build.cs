// Copyright 2022 Maschinen-Mensch UG

using UnrealBuildTool;
using System.IO;

public class Codecks : ModuleRules
{
    public Codecks(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
                Path.Combine(ModuleDirectory, "Public")
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "HTTP",
                "Json",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "DeveloperSettings"
            }
        );

    }
}
