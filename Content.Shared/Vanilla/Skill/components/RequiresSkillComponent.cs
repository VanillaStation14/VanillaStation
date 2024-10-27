using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class RequiresSkillComponent : Component
    {
        [DataField("RequiresChemistryLevel"), AutoNetworkedField]
        public int RequiresChemistryLevel { get; set; } = 0;

        [DataField("RequiresMedicineLevel"), AutoNetworkedField]
        public int RequiresMedicineLevel { get; set; } = 0;

        [DataField("RequiresPilotingLevel"), AutoNetworkedField]
        public int RequiresPilotingLevel { get; set; } = 0;

        [DataField("RequiresPilotingLevelForMap"), AutoNetworkedField]
        public int RequiresPilotingLevelForMap { get; set; } = 0;

        [DataField("RequiresPilotingLevelForCoord"), AutoNetworkedField]
        public int RequiresPilotingLevelForCoord { get; set; } = 0;
    }
}
