using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class RequiresSkillComponent : Component
    {
        //Химия
        [DataField("RequiresChemistryLevel"), AutoNetworkedField]
        public int RequiresChemistryLevel { get; set; } = 0;
        [DataField("SkillDiffChemistryLevel"), AutoNetworkedField]
        public int SkillDiffChemistryLevel { get; set; } = 0;

        //Медицина
        [DataField("RequiresMedicineLevel"), AutoNetworkedField]
        public int RequiresMedicineLevel { get; set; } = 0;
        [DataField("SkillDiffMedicineLevel"), AutoNetworkedField]
        public int SkillDiffMedicineLevel { get; set; } = 0;

        //Пилотирование
        [DataField("RequiresPilotingLevel"), AutoNetworkedField]
        public int RequiresPilotingLevel { get; set; } = 0;
        [DataField("RequiresPilotingLevelForMap"), AutoNetworkedField]
        public int RequiresPilotingLevelForMap { get; set; } = 0;
        [DataField("RequiresPilotingLevelForCoord"), AutoNetworkedField]
        public int RequiresPilotingLevelForCoord { get; set; } = 0;

        //Исследования
        [DataField("RequiresResearchLevel"), AutoNetworkedField]
        public int RequiresResearchLevel { get; set; } = 0;
        [DataField("SkillDiffResearchLevel"), AutoNetworkedField]
        public int SkillDiffResearchLevel { get; set; } = 0;

        //Приборостроение
        [DataField("RequiresInstrumentationLevel"), AutoNetworkedField]
        public int RequiresInstrumentationLevel { get; set; } = 0;

        //Инженерия
        [DataField("RequiresEngineeringLevel"), AutoNetworkedField]
        public int RequiresEngineeringLevel { get; set; } = 0;

        //Строительство
        [DataField("RequiresBuildingLevel"), AutoNetworkedField]
        public int RequiresBuildingLevel { get; set; } = 0;
    }
}
