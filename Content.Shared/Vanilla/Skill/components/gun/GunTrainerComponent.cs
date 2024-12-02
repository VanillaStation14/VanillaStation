using Robust.Shared.GameStates;

namespace Content.Shared.Vanilla.Skill
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class GunTrainerComponent : Component
    {
        [DataField("ExpPerShot"), AutoNetworkedField]
        public int ExpPerShot { get; set; } = 1;

        [DataField("MaxLevel"), AutoNetworkedField]
        public int MaxLevel { get; set; } = 3;

        [DataField("SkillType"), AutoNetworkedField]
        public string SkillType { get; set; } = "RangeWeapon";

    }
}
