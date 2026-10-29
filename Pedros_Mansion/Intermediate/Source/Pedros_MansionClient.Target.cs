using UnrealBuildTool;

public class Pedros_MansionClientTarget : TargetRules
{
	public Pedros_MansionClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Pedros_Mansion");
	}
}
