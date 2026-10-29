using UnrealBuildTool;

public class Pedros_MansionEditorTarget : TargetRules
{
	public Pedros_MansionEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Pedros_Mansion");
	}
}
