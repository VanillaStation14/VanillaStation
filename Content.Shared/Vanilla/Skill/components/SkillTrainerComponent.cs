using Content.Shared.Interaction;
using Content.Shared.Popups;
using Content.Shared.Vanilla.Skill;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;

namespace Content.Shared.SkillTrainer
{
    [RegisterComponent]
    public sealed partial class SkillTrainerComponent : Component
    {
        [DataField("skillIncreaseAmount")]
        public int SkillIncreaseAmount { get; set; } = 30;

        [DataField("skillType")]
        public string SkillType { get; set; } = "Chemistry";
        
        [DataField("ReadTime")]
        public float ReadTime { get; set; } = 10f; 

        [DataField("MaxLevel")]
        public int MaxLevel { get; set; } = 0; 
    }
}
