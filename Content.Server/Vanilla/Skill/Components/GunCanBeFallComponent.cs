using Robust.Shared.GameStates;

namespace Content.Server.Vanilla.Skill
{
    [RegisterComponent]
    public sealed partial class GunCanBeFallComponent : Component
    {
        [DataField("RequiresRangeWeaponLevel")]
        public int RequiresRangeWeaponLevel { get; set; } = 1;

        [DataField("Recoil")]
        public float Recoil { get; set; } = 10f;

        [DataField("ChanceToFallPerLevel")]
        public float ChanceToFallPerLevel { get; set; } = 0.5f;
    }
}
