using Content.Shared.Interaction;
using Content.Shared.Popups;
using Content.Shared.Vanilla.Skill;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;

namespace Content.Shared.SkillTrainer;

[RegisterComponent]
public sealed partial class SkillTrainerComponent : Component
{
    [DataField("skillIncreaseAmount")]
    public int SkillIncreaseAmount { get; set; } = 30;

    [DataField("skillType")]
    public skillType SkillType = skillType.Piloting | skillType.RangeWeapon |skillType.MeleeWeapon |skillType.Medicine |skillType.Chemistry |skillType.Engineering |skillType.Building |skillType.Research |skillType.Instrumentation;
    
    [DataField("ReadTime")]
    public float ReadTime { get; set; } = 10f; 
}

