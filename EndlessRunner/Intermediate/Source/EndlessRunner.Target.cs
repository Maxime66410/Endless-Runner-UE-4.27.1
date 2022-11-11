using UnrealBuildTool;

public class EndlessRunnerTarget : TargetRules
{
	public EndlessRunnerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("EndlessRunner");
	}
}
