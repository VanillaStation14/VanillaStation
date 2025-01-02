using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Vanilla.Skill;

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
    [DataField("PilotingExpToLearn"), AutoNetworkedField]
    public int PilotingExpToLearn { get; set; } = 900;

    //Стрельба
    [DataField("RangeWeaponLevel"), AutoNetworkedField]
    public int RangeWeaponLevel { get; set; } = 0;
    [DataField("RangeWeaponExp"), AutoNetworkedField]
    public int RangeWeaponExp { get; set; } = 0;
    [DataField("RangeWeaponExpToLearn"), AutoNetworkedField]
    public int RangeWeaponExpToLearn { get; set; } = 900;

    //Ближний бой
    [DataField("MeleeWeaponLevel"), AutoNetworkedField]
    public int MeleeWeaponLevel { get; set; } = 0;
    [DataField("MeleeWeaponExp"), AutoNetworkedField]
    public int MeleeWeaponExp { get; set; } = 0;
    [DataField("MeleeWeaponExpToLearn"), AutoNetworkedField]
    public int MeleeWeaponExpToLearn { get; set; } = 900;

    //Медицина
    [DataField("MedicineLevel"), AutoNetworkedField]
    public int MedicineLevel { get; set; } = 0;
    [DataField("MedicineExp"), AutoNetworkedField]
    public int MedicineExp { get; set; } = 0;
    [DataField("MedicineExpToLearn"), AutoNetworkedField]
    public int MedicineExpToLearn { get; set; } = 900;

    //Химия
    [DataField("ChemistryLevel"), AutoNetworkedField]
    public int ChemistryLevel { get; set; } = 0;
    [DataField("ChemistryExp"), AutoNetworkedField]
    public int ChemistryExp { get; set; } = 0;
    [DataField("ChemistryExpToLearn"), AutoNetworkedField]
    public int ChemistryExpToLearn { get; set; } = 900;

    //Инженерия
    [DataField("EngineeringLevel"), AutoNetworkedField]
    public int EngineeringLevel { get; set; } = 0;
    [DataField("EngineeringExp"), AutoNetworkedField]
    public int EngineeringExp { get; set; } = 0;
    [DataField("EngineeringExpToLearn"), AutoNetworkedField]
    public int EngineeringExpToLearn { get; set; } = 900;

    //Строительство
    [DataField("BuildingLevel"), AutoNetworkedField]
    public int BuildingLevel { get; set; } = 0;
    [DataField("BuildingExp"), AutoNetworkedField]
    public int BuildingExp { get; set; } = 0;
    [DataField("BuildingExpToLearn"), AutoNetworkedField]
    public int BuildingExpToLearn { get; set; } = 900;

    //Исследования
    [DataField("ResearchLevel"), AutoNetworkedField]
    public int ResearchLevel { get; set; } = 0;
    [DataField("ResearchExp"), AutoNetworkedField]
    public int ResearchExp { get; set; } = 0;
    [DataField("ResearchExpToLearn"), AutoNetworkedField]
    public int ResearchExpToLearn { get; set; } = 900;

    //Приборостроение
    [DataField("InstrumentationLevel"), AutoNetworkedField]
    public int InstrumentationLevel { get; set; } = 0;
    [DataField("InstrumentationExp"), AutoNetworkedField]
    public int InstrumentationExp { get; set; } = 0;
    [DataField("InstrumentationExpToLearn"), AutoNetworkedField]
    public int InstrumentationExpToLearn { get; set; } = 900;


    //получить доступное количество опыта на обучение
    public int GetSkillExpToLearn(skillType skill)
    {
        return skill switch
        {
            skillType.Chemistry => ChemistryExpToLearn,
            skillType.Medicine => MedicineExpToLearn,
            skillType.RangeWeapon => RangeWeaponLevel,
            skillType.MeleeWeapon => MeleeWeaponExpToLearn,
            skillType.Piloting => PilotingExpToLearn,
            skillType.Research => ResearchExpToLearn,
            skillType.Instrumentation => InstrumentationExpToLearn,
            skillType.Building => BuildingExpToLearn,
            skillType.Engineering => EngineeringExpToLearn,
            _ => -1
        };
    }

    //получить уровень навыка
    public int GetSkillLevel(skillType skill)
    {
        return skill switch
        {
            skillType.Chemistry => ChemistryLevel,
            skillType.Medicine => MedicineLevel,
            skillType.RangeWeapon => RangeWeaponLevel,
            skillType.MeleeWeapon => MeleeWeaponLevel,
            skillType.Piloting => PilotingLevel,
            skillType.Research => ResearchLevel,
            skillType.Instrumentation => InstrumentationLevel,
            skillType.Building => BuildingLevel,
            skillType.Engineering => EngineeringLevel,
            _ => -1
        };
    }

    //получить опыт навыка
    public int GetSkillExp(skillType skill)
    {
        return skill switch
        {
            skillType.Chemistry => ChemistryExp,
            skillType.Medicine => MedicineExp,
            skillType.RangeWeapon => RangeWeaponExp,
            skillType.MeleeWeapon => MeleeWeaponExp,
            skillType.Piloting => PilotingExp,
            skillType.Research => ResearchExp,
            skillType.Instrumentation => InstrumentationExp,
            skillType.Building => BuildingExp,
            skillType.Engineering => EngineeringExp,
            _ => -1
        };
    }

}

[Serializable, NetSerializable]
public enum skillType : byte
{
    Piloting = 0,
    RangeWeapon = 1,
    MeleeWeapon = 2,
    Medicine = 3,
    Chemistry = 4,
    Engineering = 5,
    Building = 6,
    Research = 7,
    Instrumentation = 8
}
