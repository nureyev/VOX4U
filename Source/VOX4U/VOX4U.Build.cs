// Copyright 2016 mik14a / Admix Network. All Rights Reserved.

using UnrealBuildTool;

public class VOX4U : ModuleRules
{
    public VOX4U(TargetInfo Target) {

        PublicIncludePaths.AddRange(
            new string[] {
                "VOX4U/Public"
            }
        );

        PrivateIncludePaths.AddRange(
            new string[] {
                "VOX4U/Private",
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "UnrealEd",
                "RawMesh",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
            }
        );

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
        );
    }
}
