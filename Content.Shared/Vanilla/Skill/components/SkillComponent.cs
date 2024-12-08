using Robust.Shared.GameStates;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class SkillComponent : Component
    {
        //очки навыков
        [DataField("SkillPoints"), AutoNetworkedField]
        public int SkillPoints { get; set; } = 0;

        //Пилотирование
        [DataField("PilotingLevel"), AutoNetworkedField]
        public int PilotingLevel { get; set; } = 0;
        [DataField("PilotingExp"), AutoNetworkedField]
        public int PilotingExp { get; set; } = 0;

        //Стрельба
        [DataField("RangeWeaponLevel"), AutoNetworkedField]
        public int RangeWeaponLevel { get; set; } = 0;
        [DataField("RangeWeaponExp"), AutoNetworkedField]
        public int RangeWeaponExp { get; set; } = 0;

        //Ближний бой
        [DataField("MeleeWeaponLevel"), AutoNetworkedField]
        public int MeleeWeaponLevel { get; set; } = 0;
        [DataField("MeleeWeaponExp"), AutoNetworkedField]
        public int MeleeWeaponExp { get; set; } = 0;

        //Медицина
        [DataField("MedicineLevel"), AutoNetworkedField]
        public int MedicineLevel { get; set; } = 0;
        [DataField("MedicineExp"), AutoNetworkedField]
        public int MedicineExp { get; set; } = 0;

        //Химия
        [DataField("ChemistryLevel"), AutoNetworkedField]
        public int ChemistryLevel { get; set; } = 0;
        [DataField("ChemistryExp"), AutoNetworkedField]
        public int ChemistryExp { get; set; } = 0;

        //Инженерия
        [DataField("EngineeringLevel"), AutoNetworkedField]
        public int EngineeringLevel { get; set; } = 0;
        [DataField("EngineeringExp"), AutoNetworkedField]
        public int EngineeringExp { get; set; } = 0;

        //Строительство
        [DataField("BuildingLevel"), AutoNetworkedField]
        public int BuildingLevel { get; set; } = 0;
        [DataField("BuildingExp"), AutoNetworkedField]
        public int BuildingExp { get; set; } = 0;

        //Исследования
        [DataField("ResearchLevel"), AutoNetworkedField]
        public int ResearchLevel { get; set; } = 0;
        [DataField("ResearchExp"), AutoNetworkedField]
        public int ResearchExp { get; set; } = 0;

        //Приборостроение
        [DataField("InstrumentationLevel"), AutoNetworkedField]
        public int InstrumentationLevel { get; set; } = 0;
        [DataField("InstrumentationExp"), AutoNetworkedField]
        public int InstrumentationExp { get; set; } = 0;
    }
}
