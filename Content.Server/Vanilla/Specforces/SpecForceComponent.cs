using Robust.Shared.Prototypes;

namespace Content.Server.vanilla.SpecForces;

[RegisterComponent]
public sealed partial class SpecForceComponent : Component
{
    /// <summary>
    /// A dictionary mapping the component type list to the YAML mapping containing their settings.
    /// </summary>

    [DataField("components")]
    [AlwaysPushInheritance]
    public ComponentRegistry Components { get; private set; } = new();

    public EntityUid? BssKey = null;
}

public sealed class SpecForcesHistory
{
    public TimeSpan RoundTime {get;set;}
    public string Event {get;set;} = default!;
    public string WhoCalled {get;set;} = default!;
}