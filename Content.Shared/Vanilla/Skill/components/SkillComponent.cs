using Robust.Shared.GameStates;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class SkillComponent : Component
    {
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
        [DataField("engineeringExp"), AutoNetworkedField]
        public int EngineeringExp { get; set; } = 0;

        //Строительство
        [DataField("BuildigLevel"), AutoNetworkedField]
        public int BuildigLevel { get; set; } = 0;
        [DataField("BuildigExp"), AutoNetworkedField]
        public int BuildigExp { get; set; } = 0;

        //Исследования
        [DataField("ResearchLevel"), AutoNetworkedField]
        public int ResearchLevel { get; set; } = 0;
        [DataField("ResearchExp"), AutoNetworkedField]
        public int ResearchExp { get; set; } = 0;

        //Робототехника
        [DataField("RoboticsLevel"), AutoNetworkedField]
        public int RoboticsLevel { get; set; } = 0;
        [DataField("RoboticsExp"), AutoNetworkedField]
        public int RoboticsExp { get; set; } = 0;
    }
}
