using Robust.Shared.GameStates;

namespace Content.Server.Vanilla.Skill
{
    [RegisterComponent]
    public sealed partial class AddSkillPointsComponent : Component
    {
        // Значение для установки в CurrentPoints
        [DataField("Points")]
        public int Points { get; set; } = 0;
    }
}
