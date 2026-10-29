using UnrealBuildTool;

public class Pedros_MansionServerTarget : TargetRules
{
	public Pedros_MansionServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Pedros_Mansion");
	}
}
