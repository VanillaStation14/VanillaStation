using Content.Shared.Interaction;
using Content.Shared.Popups;
using Content.Shared.Vanilla.Skill;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;

namespace Content.Shared.SkillTrainer;

    [RegisterComponent]
    public sealed partial class SkillTrainerComponent : Component
    {
        [DataField("SkillIncreaseAmount")]
        public int SkillIncreaseAmount { get; set; } = 30;

        [DataField("SkillType")]
        public skillType SkillType { get; set; }
        
        [DataField("ReadTime")]
        public float ReadTime { get; set; } = 10f; 
    }
