using UnrealBuildTool;

public class Pedros_MansionTarget : TargetRules
{
	public Pedros_MansionTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Pedros_Mansion");
	}
}
