using Robust.Shared.GameStates;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class SkillComponent : Component
    {
        [DataField("MedicineLevel"), AutoNetworkedField]
        public int MedicineLevel { get; set; } = 0;

        [DataField("ChemistryLevel"), AutoNetworkedField]
        public int ChemistryLevel { get; set; } = 0;

        [DataField("RangeWeaponLevel"), AutoNetworkedField]
        public int RangeWeaponLevel { get; set; } = 0;

        [DataField("MedicineExp"), AutoNetworkedField]
        public int MedicineExp { get; set; } = 0;

        [DataField("ChemistryExp"), AutoNetworkedField]
        public int ChemistryExp { get; set; } = 0;

        [DataField("RangeWeaponExp"), AutoNetworkedField]
        public int RangeWeaponExp { get; set; } = 0;

        [DataField("PilotingLevel"), AutoNetworkedField]
        public int PilotingLevel { get; set; } = 0;

        [DataField("PilotingExp"), AutoNetworkedField]
        public int PilotingExp { get; set; } = 0;
    }
}
